using FreshMvvmTemplate.Core.Services.Rest;
using Polly;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;


namespace FreshMvvmTemplate.Core.Data.Api
{
    public class ApiManager
    {
        IConnectivity _connectivity;

        public bool IsConnected { get; set; }
        Dictionary<int, CancellationTokenSource> runningTasks = new Dictionary<int, CancellationTokenSource>();
        Dictionary<string, Task<HttpResponseMessage>> taskContainer = new Dictionary<string, Task<HttpResponseMessage>>();

        public ApiManager(IApiService<IRestApi> _restApi)
        {
            IsConnected = _connectivity.IsConnected;
            _connectivity.ConnectivityChanged += OnConnectivityChanged;
        }

        void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            IsConnected = e.NetworkAccess != NetworkAccess.Internet;

            if (!IsConnected)
            {
                // Cancel All Running Task
                var items = runningTasks.ToList();
                foreach (var item in items)
                {
                    item.Value.Cancel();
                    runningTasks.Remove(item.Key);
                }
            }
        }

        protected async Task<Services.Rest.ApiResponse<TData>> RemoteRequestAsync<TData>(
            Task<Services.Rest.ApiResponse<TData>> task)
            where TData : class,
            new()
        {
            Services.Rest.ApiResponse<TData> data = new Services.Rest.ApiResponse<TData>();

            if (!IsConnected)
            {
                data.StatusCode = HttpStatusCode.BadRequest;
                data.UserMessage = "There's no network connection";

                //TODO : Add userdialogs
                // _userDialogs.Toast(strngResponse, TimeSpan.FromSeconds(1));
                return data;
            }

            data = await Policy
            .Handle<WebException>()
            .Or<ApiException>()
            .Or<TaskCanceledException>()
            .WaitAndRetryAsync
            (
                retryCount: 3,
                sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
            )
            .ExecuteAsync(async () =>
            {
                var result = await task;

                if (result.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //TODO: Add retry logic
                    //if (retry == 1)
                    //{
                    //    // The first time an Unauthorized exception occurs, 
                    //    // try to aquire an Access Token silently and try again
                    //    await authenticationService.LoginSilentAsync();
                    //}
                    //else if (retry == 2)
                    //{
                    //    // If refreshing the access token silently failed, show the login UI 
                    //    // and let the user enter his credentials again
                    //    await authenticationService.LoginAsync();
                    //}

                }
                runningTasks.Remove(task.Id);

                return result;
            });

            return data;
        }

        /// <summary>
        /// This is an example of making the api call
        /// </summary>
        /// <returns></returns>
        //public async Task<HttpResponseMessage> GetNews()
        //{
        //    var cts = new CancellationTokenSource();
        //    var task = RemoteRequestAsync<HttpResponseMessage>(redditApi.GetApi(Priority.UserInitiated).GetNews(cts.Token));
        //    runningTasks.Add(task.Id, cts);

        //    return await task;
        //}

    }

}


using System;
using System.Net.Http;
using FreshMvvmTemplate.Core.Data.Tools;
using Fusillade;
using Refit;

namespace FreshMvvmTemplate.Core.Services.Rest
{
    public class ApiService<T> : IApiService<T>
    {
        Func<HttpMessageHandler, T> createClient;
        public ApiService(string apiBaseAddress)
        {
            createClient = messageHandler =>
            {
                var client = new HttpClient(messageHandler)
                {
                    BaseAddress = new Uri(apiBaseAddress)
                };

                return RestService.For<T>(client);
            };
        }

        private T Background
        {
            get
            {
            #if DEBUG
                return new Lazy<T>(() => createClient(
                new RateLimitedHttpMessageHandler(new HttpLoggingAndAuthenticationHandler(), Priority.Background))).Value;
            #else
                return new Lazy<T>(() => createClient(
                new RateLimitedHttpMessageHandler(new HttpAuthenticationHandler(), Priority.Background))).Value;
            #endif  
            }
        }

        private T UserInitiated
        {
            get
            {

            #if DEBUG
                return new Lazy<T>(() => createClient(
                new RateLimitedHttpMessageHandler(new HttpLoggingAndAuthenticationHandler(), Priority.UserInitiated))).Value;
            #else
                return new Lazy<T>(() => createClient(
                new RateLimitedHttpMessageHandler(new HttpAuthenticationHandler(), Priority.UserInitiated))).Value;
            #endif  
            }
        }

        private T Speculative
        {
            get
            {
            #if DEBUG
                return new Lazy<T>(() => createClient(
                new RateLimitedHttpMessageHandler(new HttpLoggingAndAuthenticationHandler(), Priority.Speculative))).Value;
            #else
                return new Lazy<T>(() => createClient(
                new RateLimitedHttpMessageHandler(new HttpAuthenticationHandler(), Priority.Speculative))).Value;
            #endif
            }
        }

        public T GetApi(Priority priority)
        {
            switch (priority)
            {
                case Priority.Background:
                    return Background;
                case Priority.UserInitiated:
                    return UserInitiated;
                case Priority.Speculative:
                    return Speculative;
                default:
                    return UserInitiated;
            }
        }

    }
}

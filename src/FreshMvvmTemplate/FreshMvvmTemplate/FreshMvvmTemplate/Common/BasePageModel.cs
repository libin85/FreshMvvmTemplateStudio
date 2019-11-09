using FreshMvvm;
using System;
using System.Threading;
using Xamarin.Essentials;

namespace FreshMvvmTemplate.Common
{
    public class BasePageModel : FreshBasePageModel, IDisposable
    {
        readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly IConnectivity _connectivity;
        public BasePageModel(IConnectivity connectivity)
        {
            _connectivity = connectivity;
            _isConnected = _connectivity.IsConnected;
            _connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            IsConnected = e.NetworkAccess != NetworkAccess.Internet;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        private bool _isConnected = false;
        public bool IsConnected
        {
            get => _isConnected;
            set { _isConnected = value; RaisePropertyChanged(); }
        }
        public CancellationToken CancellationToken => _cancellationTokenSource?.Token ?? CancellationToken.None;

        private bool _isBusy = false;
        public bool IsBusy
        { get => _isBusy;
            set { _isBusy = value; RaisePropertyChanged(); }
        }

        ~BasePageModel()
        {
            _connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
            Dispose(false);
        }
    }
}

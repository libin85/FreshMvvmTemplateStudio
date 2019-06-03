using FreshMvvmTemplate.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FreshMvvmTemplate.Common
{
    public class AppConnectivity : IConnectivity
    {
        public bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;

        public event EventHandler<ConnectivityChangedEventArgs> ConnectivityChanged;
    }
}

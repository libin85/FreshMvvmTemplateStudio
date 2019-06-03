using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FreshMvvmTemplate.Common
{
    public interface IConnectivity
    {
        bool IsConnected { get; }

        event EventHandler<ConnectivityChangedEventArgs> ConnectivityChanged;
    }
}

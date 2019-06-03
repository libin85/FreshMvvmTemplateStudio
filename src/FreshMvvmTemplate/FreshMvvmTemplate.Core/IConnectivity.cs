using System;
using Xamarin.Essentials;

namespace FreshMvvmTemplate.Core
{
    public interface IConnectivity
    {
        bool IsConnected { get; }

        event EventHandler<ConnectivityChangedEventArgs> ConnectivityChanged;
    }
}

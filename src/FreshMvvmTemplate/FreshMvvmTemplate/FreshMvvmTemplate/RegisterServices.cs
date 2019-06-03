using FreshMvvm;
using FreshMvvmTemplate.Common;
#if (Caching == monkeycachesqlite)
using FreshMvvmTemplate.Core.Data.Cache;
#endif
#if (Logging == appcenter)
using FreshMvvmTemplate.Core.Logging;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
using ILogger = FreshMvvmTemplate.Core.Logging.ILogger;
#endif

namespace FreshMvvmTemplate
{
    public class RegisterServices
    {
        /// <summary>
        /// This method registers and initialises all the services created/used in this library.
        /// This method method is called in the App.xaml.cs
        /// </summary>
        public static void Init()
        {
            #if (Logging == appcenter)
            //Register the Logger class.
            FreshIOC.Container.Register<ILogger, Logger>().AsSingleton();

            //Initialise AppCenter
            AppCenter.Start("ios={Your App Secret};android={Your App Secret}", typeof(Crashes));
            #endif

            //Register the Connectivity class.
            FreshIOC.Container.Register<IConnectivity, AppConnectivity>().AsSingleton();

           
            #if (Caching == monkeycachesqlite)
            //Initialise MonkeyCache
            MonkeyCacheInstance.Init();
            #endif
        }
    }
}

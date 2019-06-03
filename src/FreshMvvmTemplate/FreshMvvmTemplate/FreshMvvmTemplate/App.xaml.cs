using FreshMvvm;
using FreshMvvmTemplate.Core.Configuration;
using FreshMvvmTemplate.PageModels;
using Xamarin.Forms;

namespace FreshMvvmTemplate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var test = ConfigurationManager.Settings["Service"];
            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
            RegisterServices.Init();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

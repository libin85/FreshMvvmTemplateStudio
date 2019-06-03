using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmEnterpriseWizard.Models
{
    public class ProjectDetail : BaseModel
    {
        public static string Title { get; set; }

        public List<ProjectTarget> TargetProjects { get; set; }

        public int AndroidMinTareget { get; set; }

        public UnitTestType UnitTestProject { get; set; }

        public NavigationType NavigationType { get; set; }

        public ProjectFeatures ProjectFeatures { get; set; }
    }

    public enum ProjectTarget
    {
        Android,
        iOS,
        XamarinUITest
    }

    public enum UnitTestType
    {
        None,
        XUnit,
        NUnit,
        MSTest
    }

    public enum NavigationType
    {
        None,
        Hamburger,
        TabbedPage,
        Shell
    }

    public enum ErrorLogging
    {
        None,
        AzureAppInsights,
        Serilog
    }

    public enum ApiAccess
    {
        None,
        Refit
    }

    public enum DatabaseProvider
    {
        None,
        AzureMobileClient,
        SqLite,
        Realm
    }

    public enum AuthenticationStyle
    {
        None,
        SimpleAuthentication,
        AuthorizationCode
    }

    public enum Caching
    {
        None,
        MonkeyCacheSqLite,
        MonketCacheLiteDb,
        Akavache
    }

    public class ProjectFeatures
    {
        public ErrorLogging ErrorLogging { get; set; }
        public ApiAccess ApiAccess { get; set; }
        public DatabaseProvider DatabaseProvider { get; set; }
        public bool PopupInstance { get; set; }
        public AuthenticationStyle AuthenticationStyle { get; set; }
        public bool LocalNotification { get; set; }
        public bool Behaviors { get; set; }
        public bool ConnectivityNotification { get; set; }
    }
    
}


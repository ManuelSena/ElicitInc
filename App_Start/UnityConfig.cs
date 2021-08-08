using ElicitInc.Services;
using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Web.Mvc;
using Unity.WebApi;

namespace ElicitInc
{
    public sealed class UnityConfig
    {
        private static readonly UnityConfig _instance = new UnityConfig();
        static UnityConfig() { }
        private UnityConfig() { }
        public static UnityConfig Instance { get { return _instance; } }

        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IElicitService, ElicitService>();
            //container.RegisterType<IWebScrapeService, WebScrapeService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
        }
    }
}


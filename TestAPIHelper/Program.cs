using CommonServiceLocator;
using SC2Community;
using SC2Community.OAuth;
using SC2Community.WebRequests;
using System;
using System.Threading.Tasks;
using Unity;
using Unity.ServiceLocation;

namespace TestAPIHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterDependencies();
            Console.WriteLine("All Dependencies Registered");

            Console.ReadLine();
        }

        private static void RegisterDependencies()
        {
            var _container = new UnityContainer();
            var container = new UnityServiceLocator(_container);
            ServiceLocator.SetLocatorProvider(() => container);

            _container.RegisterInstance<IOAuthCredentials>(new OAuthCredentials("", ""));
            _container.RegisterSingleton<IOAuthTokenProvider, OAuthTokenProvider>();
            _container.RegisterSingleton<IWebRequestConfiguration, WebRequestConfiguration>();
            _container.RegisterSingleton<IWebRequestMachine, WebRequestMachine>();

        }
    }
}

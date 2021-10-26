using CommonServiceLocator;
using SC2CommunityAPI;
using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
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
            //RegisterDependencies();
            //Console.WriteLine("All Dependencies Registered");
            TestRequest();

            Console.ReadLine();
        }

        private static async void TestRequest()
        {
            WebRequestMachine machine = new WebRequestMachine(
                new OAuthTokenProvider(
                    new OAuthCredentials("", ""))
                , new WebRequestConfiguration(5));
            Endpoints ep = new Endpoints(machine);
            var r = await ep.GetLeagueDataAsync(Region.EU, "48", QueueId.LotV1v1, TeamType.Arranged, LeagueId.Master);
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

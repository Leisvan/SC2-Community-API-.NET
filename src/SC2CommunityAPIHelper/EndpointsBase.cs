using Newtonsoft.Json;
using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System.Threading.Tasks;

namespace SC2CommunityAPI
{
    public class EndpointsBase
    {
        protected const string DEF_LOCALE = "en_US";

        protected readonly IWebRequestMachine requestMachine;

        public EndpointsBase(IOAuthTokenProvider tokenProvider)
            : this(new WebRequestMachine(tokenProvider, new WebRequestConfiguration()))
        {

        }
        public EndpointsBase(IWebRequestMachine requestMachine)
        {
            this.requestMachine = requestMachine;
        }

        protected async Task<EndpointResponse<T>> GetResponseAsync<T>(string url)
        {
            var response = await requestMachine.GetResponseAsync(url);
            T jsonResult = JsonConvert.DeserializeObject<T>(response.Body);
            return new EndpointResponse<T>
            {
                StatusDescription = response.StatusDescription,
                Body = response.Body,
                FormattedData = jsonResult,
            };
        }
        protected static string GetHostNameRegionString(HostNameRegion region)
        {
            return region switch
            {
                HostNameRegion.EU => "eu",
                HostNameRegion.KR => "kr",
                _ => "us",
            };
        }
        protected static EndpointResponse<T> GetRequestResult<T>(HttpResponseData data)
        {
            T jsonResult = JsonConvert.DeserializeObject<T>(data.Body);
            return new EndpointResponse<T>
            {
                StatusDescription = data.StatusDescription,
                Body = data.Body,
                FormattedData = jsonResult,
            };
        }
    }
}
using Newtonsoft.Json;
using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System.Threading.Tasks;

namespace SC2CommunityAPI
{
    public abstract class BaseAPI
    {
        protected const string DEF_LOCALE = "en_US";

        protected readonly IWebRequestMachine requestMachine;

        public BaseAPI(IOAuthTokenProvider tokenProvider)
            : this(new WebRequestMachine(tokenProvider, new WebRequestConfiguration()))
        {

        }
        public BaseAPI(IWebRequestMachine requestMachine)
        {
            this.requestMachine = requestMachine;
        }

        protected async Task<APIResponse<T>> GetResponseAsync<T>(string url)
        {
            var response = await requestMachine.GetResponseAsync(url);
            T jsonResult = JsonConvert.DeserializeObject<T>(response.Body);
            return new APIResponse<T>
            {
                StatusDescription = response.StatusDescription,
                Body = response.Body,
                Model = jsonResult,
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
        protected static APIResponse<T> GetRequestResult<T>(HttpResponseData data)
        {
            T jsonResult = JsonConvert.DeserializeObject<T>(data.Body);
            return new APIResponse<T>
            {
                StatusDescription = data.StatusDescription,
                Body = data.Body,
                Model = jsonResult,
            };
        }
        protected static HostNameRegion Convert(Region region)
        {
            return region switch
            {
                Region.EU => HostNameRegion.EU,
                Region.KR => HostNameRegion.KR,
                _ => HostNameRegion.NA,
            };
        }
    }
}
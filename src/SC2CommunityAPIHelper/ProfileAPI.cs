using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SC2CommunityAPI
{
    public class ProfileAPI: BaseAPI
    {
        private const string URI_STATIC = "https://{0}.api.blizzard.com/sc2/static/profile/{1}?locale={2}";
        public ProfileAPI(IOAuthTokenProvider tokenProvider) : base(tokenProvider)
        {

        }
        public ProfileAPI(IWebRequestMachine requestMachine) : base(requestMachine)
        {

        }

        public async Task<APIResponse<StaticJson>> GetStaticAsync(HostNameRegion hostNameRegion, Region region, string locale = DEF_LOCALE)
        {
            string formattedUrl = string.Format(URI_STATIC, GetHostNameRegionString((HostNameRegion)(int)hostNameRegion), (int)region, locale);
            return await GetResponseAsync<StaticJson>(formattedUrl);
        }
    }
}

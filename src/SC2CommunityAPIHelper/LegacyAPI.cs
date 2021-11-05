using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SC2CommunityAPI
{
    public class LegacyAPI : BaseAPI
    {
        private const string URI_PROFILE = "https://{0}.api.blizzard.com/sc2/legacy/profile/{1}/{2}/{3}";
        public LegacyAPI(IOAuthTokenProvider tokenProvider) : base(tokenProvider)
        {

        }
        public LegacyAPI(IWebRequestMachine requestMachine) : base(requestMachine)
        {

        }

        public async Task<APIResponse<LegacyProfileJson>> GetProfileAsync(HostNameRegion hostNameRegion, Region region, int realmId, int profileId)
        {
            string formattedUrl = string.Format(URI_PROFILE, GetHostNameRegionString(hostNameRegion), (int)region, realmId, profileId);
            return await GetResponseAsync<LegacyProfileJson>(formattedUrl);
        }

    }
}

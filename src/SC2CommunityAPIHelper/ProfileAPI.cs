using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SC2CommunityAPI
{
    public class ProfileAPI : BaseAPI
    {
        private const string URI_STATIC = "https://{0}.api.blizzard.com/sc2/static/profile/{1}?locale={2}";
        private const string URI_METADATA = "https://{0}.api.blizzard.com/sc2/metadata/profile/{1}/{2}/{3}";
        public ProfileAPI(IOAuthTokenProvider tokenProvider) : base(tokenProvider)
        {

        }
        public ProfileAPI(IWebRequestMachine requestMachine) : base(requestMachine)
        {

        }

        public async Task<APIResponse<StaticJson>> GetStaticAsync(HostNameRegion hostNameRegion, Region region, string locale = DEF_LOCALE)
        {
            string formattedUrl = string.Format(URI_STATIC, GetHostNameRegionString(hostNameRegion), (int)region, locale);
            return await GetResponseAsync<StaticJson>(formattedUrl);
        }

        public async Task<APIResponse<MetadataJson>> GetMetadataAsync(HostNameRegion hostNameRegion, Region region, int realmId, int profileId, string locale = DEF_LOCALE)
        {
            string formattedUrl = string.Format(URI_METADATA, GetHostNameRegionString(hostNameRegion), (int)region, realmId, profileId, locale);
            return await GetResponseAsync<MetadataJson>(formattedUrl);

        }
    }
}

using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SC2CommunityAPI
{
    public class LadderAPI : BaseAPI
    {
        private const string URI_GMLEADERBOARD = "https://{0}.api.blizzard.com/sc2/ladder/grandmaster/{1}";
        private const string URI_SEASON = "https://{0}.api.blizzard.com/sc2/ladder/season/{1}";

        public LadderAPI(IOAuthTokenProvider tokenProvider):base(tokenProvider)
        {

        }
        public LadderAPI(IWebRequestMachine requestMachine):base(requestMachine)
        {
            
        }

        #region Ladder API
        public async Task<APIResponse<SeasonJson>> GetSeasonAsync(HostNameRegion hostNameRegion, Region region)
        {
            string formattedUrl = string.Format(URI_SEASON, GetHostNameRegionString(hostNameRegion), (int)region);
            return await GetResponseAsync<SeasonJson>(formattedUrl);
        }
        public async Task<APIResponse<LadderTeamsCollectionJson>> GetGrandmasterLeaderboardAsync(HostNameRegion hostNameRegion, Region region)
        {
            string formattedUrl = string.Format(URI_GMLEADERBOARD, GetHostNameRegionString(hostNameRegion), (int)region);
            return await GetResponseAsync<LadderTeamsCollectionJson>(formattedUrl);
        }
        #endregion

    }
}
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
    public class Endpoints : EndpointsBase
    {
        private const string URI_LEAGUEDATA = "https://{0}.api.blizzard.com/data/sc2/league/{1}/{2}/{3}/{4}";
        private const string URI_GMLEADERBOARD = "https://{0}.api.blizzard.com/sc2/ladder/grandmaster/{1}";
        private const string URI_SEASON = "https://{0}.api.blizzard.com/sc2/ladder/season/{1}";

        public Endpoints(IOAuthTokenProvider tokenProvider):base(tokenProvider)
        {

        }
        public Endpoints(IWebRequestMachine requestMachine):base(requestMachine)
        {
            
        }

        #region Game Data Endpoints
        /// <summary>
        /// Returns data for the specified season, queue, team, and league.
        /// Documentation: https://develop.battle.net/documentation/starcraft-2/game-data-apis
        /// </summary>
        public async Task<EndpointResponse<LeagueDataJson>> GetLeagueDataAsync(Region region, string seasonId, QueueId queueId, TeamType teamType, LeagueId leagueId, string locale = DEF_LOCALE)
        {
            string formattedUrl = string.Format(URI_LEAGUEDATA, GetHostNameRegionString((HostNameRegion)(int)region), seasonId, (int)queueId, (int)teamType, (int)leagueId, locale);
            return await GetResponseAsync<LeagueDataJson>(formattedUrl);
        }
        #endregion


        public async Task<EndpointResponse<SeasonJson>> GetSeasonAsync(HostNameRegion hostNameRegion, Region region)
        {
            string formattedUrl = string.Format(URI_SEASON, GetHostNameRegionString(hostNameRegion), (int)region);
            return await GetResponseAsync<SeasonJson>(formattedUrl);
        }
       
    }
}

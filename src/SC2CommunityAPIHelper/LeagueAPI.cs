using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SC2CommunityAPI
{
    public class LeagueAPI : BaseAPI
    {
        private const string URI_LEAGUEDATA = "https://{0}.api.blizzard.com/data/sc2/league/{1}/{2}/{3}/{4}";

        public LeagueAPI(IOAuthTokenProvider tokenProvider) : base(tokenProvider)
        {

        }
        public LeagueAPI(IWebRequestMachine requestMachine) : base(requestMachine)
        {

        }

        /// <summary>
        /// Returns data for the specified season, queue, team, and league.
        /// Documentation: https://develop.battle.net/documentation/starcraft-2/game-data-apis
        /// </summary>
        public async Task<APIResponse<LeagueDataJson>> GetLeagueDataAsync(Region region, string seasonId, QueueId queueId, TeamType teamType, LeagueId leagueId, string locale = DEF_LOCALE)
        {
            string formattedUrl = string.Format(URI_LEAGUEDATA, GetHostNameRegionString((HostNameRegion)(int)region), seasonId, (int)queueId, (int)teamType, (int)leagueId, locale);
            return await GetResponseAsync<LeagueDataJson>(formattedUrl);
        }
    }
}

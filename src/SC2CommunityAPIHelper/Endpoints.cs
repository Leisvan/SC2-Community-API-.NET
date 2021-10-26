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
    public class Endpoints
    {
        private const string URI_LEAGUEDATA = "https://{0}.api.blizzard.com/data/sc2/league/{1}/{2}/{3}/{4}";
        private const string _defLocale = "en_US";

        private readonly IWebRequestMachine requestMachine;

        public Endpoints(IOAuthTokenProvider tokenProvider)
            :this(new WebRequestMachine(tokenProvider, new WebRequestConfiguration()))
        {

        }
        public Endpoints(IWebRequestMachine requestMachine)
        {
            this.requestMachine = requestMachine;
        }

        /// <summary>
        /// Returns data for the specified season, queue, team, and league.
        /// Documentation: https://develop.battle.net/documentation/starcraft-2/game-data-apis
        /// </summary>
        public async Task<EndpointResponse<LeagueDataJson>> GetLeagueDataAsync(Regions requestRegion, string seasonId, QueueId queueId, TeamType teamType, LeagueId leagueId, string locale = _defLocale)
        {
            string formattedUrl = string.Format(URI_LEAGUEDATA, GetRegionString(requestRegion), seasonId, (int)queueId, (int)teamType, (int)leagueId, locale);
            var response = await requestMachine.GetResponseAsync(formattedUrl);
            return GetRequestResult<LeagueDataJson>(response);
        }

        #region Private Methods
        private static string GetRegionString(Regions region)
        {
            return region switch
            {
                Regions.EU => "eu",
                Regions.KR => "kr",
                _ => "us",
            };
        }
        private static EndpointResponse<T> GetRequestResult<T>(HttpResponseData data)
        {
            T jsonResult = JsonConvert.DeserializeObject<T>(data.Body);
            return new EndpointResponse<T>
            {
                StatusDescription = data.StatusDescription,
                Body = data.Body,
                FormattedData = jsonResult,
            };
        }
        #endregion

    }
}

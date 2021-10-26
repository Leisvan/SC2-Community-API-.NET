using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LeagueKeyJson
    {
        [JsonProperty("league_id")]
        public int LeagueId { get; set; }
        [JsonProperty("season_id")]
        public int SeasonId { get; set; }
        [JsonProperty("queue_id")]
        public int QueueId { get; set; }
        [JsonProperty("team_type")]
        public int TeamType { get; set; }
    }
}

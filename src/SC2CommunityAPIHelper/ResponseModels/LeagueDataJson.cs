using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LeagueDataJson
    {
        [JsonProperty("key")]
        public LeagueKeyJson Key { get; set; }
        [JsonProperty("tier")]
        public List<LeagueTierJson> Tiers { get; set; }

        public LeagueDataJson()
        {
            Tiers = new List<LeagueTierJson>();
        }
    }
}

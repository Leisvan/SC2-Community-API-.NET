using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LeagueTierJson
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("min_rating")]
        public int MinRating { get; set; }
        [JsonProperty("max_rating")]
        public int MaxRating { get; set; }

        [JsonProperty("division")]
        public List<TierDivisionJson> Divisions { get; set; }

        public LeagueTierJson()
        {
            Divisions = new List<TierDivisionJson>();
        }
    }
}

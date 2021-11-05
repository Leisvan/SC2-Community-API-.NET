using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class MemberJson
    {
        [JsonProperty("favoriteRace")]
        public string FavoriteRace { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }
    }
}

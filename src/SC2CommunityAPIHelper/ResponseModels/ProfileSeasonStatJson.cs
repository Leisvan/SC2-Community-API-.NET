using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public class ProfileSeasonStatJson
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }
    }
}

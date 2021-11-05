using Newtonsoft.Json;
using System.Collections.Generic;

namespace SC2CommunityAPI.ResponseModels
{
    public class ProfilePointsJson
    {
        [JsonProperty("totalPoints")]
        public int TotalPoints { get; set; }

        [JsonProperty("categoryPoints")]
        public Dictionary<string, int> CategoryPoints { get; set; }
    }
}

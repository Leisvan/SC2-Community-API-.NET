using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public class CampaignRaceLevelJson
    {
        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("totalLevelXP")]
        public long TotalLevelXp { get; set; }

        [JsonProperty("currentLevelXP")]
        public long CurrentLevelXp { get; set; }
    }
}

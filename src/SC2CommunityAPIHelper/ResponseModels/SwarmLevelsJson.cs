using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public class SwarmLevelsJson
    {
        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("terran")]
        public CampaignRaceLevelJson Terran { get; set; }

        [JsonProperty("zerg")]
        public CampaignRaceLevelJson Zerg { get; set; }

        [JsonProperty("protoss")]
        public CampaignRaceLevelJson Protoss { get; set; }
    }
}

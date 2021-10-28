using System.Collections.Generic;
using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public class StaticJson
    {
        [JsonProperty("achievements")]
        public List<AchievementJson> Achievements { get; set; }

        [JsonProperty("criteria")]
        public List<CriterionJson> Criteria { get; set; }

        [JsonProperty("categories")]
        public List<CategoryJson> Categories { get; set; }

        [JsonProperty("rewards")]
        public List<RewardJson> Rewards { get; set; }
    }

}

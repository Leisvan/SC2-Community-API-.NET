using Newtonsoft.Json;
using System.Collections.Generic;

namespace SC2CommunityAPI.ResponseModels
{
    public class AchievementsSummaryJson
    {
        [JsonProperty("points")]
        public ProfilePointsJson Points { get; set; }

        [JsonProperty("achievements")]
        public List<AchievementReferenceJson> AchievementsAchievements { get; set; }
    }
}

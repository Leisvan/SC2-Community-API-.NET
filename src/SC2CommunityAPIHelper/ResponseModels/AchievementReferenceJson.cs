using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public class AchievementReferenceJson
    {
        [JsonProperty("achievementId")]
        public string AchievementId { get; set; }

        [JsonProperty("completionDate")]
        public long CompletionDate { get; set; }
    }
}

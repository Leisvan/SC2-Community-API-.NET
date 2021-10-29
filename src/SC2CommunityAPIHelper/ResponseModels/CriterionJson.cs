using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public class CriterionJson
    {
        [JsonProperty("achievementId")]
        public string AchievementId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("evaluationClass")]
        public string EvaluationClass { get; set; }

        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("necessaryQuantity")]
        public long NecessaryQuantity { get; set; }

        [JsonProperty("uiOrderHint")]
        public long UiOrderHint { get; set; }
    }

}

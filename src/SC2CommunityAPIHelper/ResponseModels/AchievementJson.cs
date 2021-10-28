using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class AchievementJson
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("chainAchievementIds")]
        public List<string> ChainAchievementIds { get; set; }

        [JsonProperty("chainRewardSize")]
        public long ChainRewardSize { get; set; }

        [JsonProperty("criteriaIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CriteriaIds { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("isChained")]
        public bool IsChained { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("uiOrderHint")]
        public long UiOrderHint { get; set; }
    }

}

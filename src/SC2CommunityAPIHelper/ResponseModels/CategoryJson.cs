using System.Collections.Generic;
using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class CategoryJson
    {
        [JsonProperty("childrenCategoryIds")]
        public List<string> ChildrenCategoryIds { get; set; }

        [JsonProperty("featuredAchievementId")]
        public string FeaturedAchievementId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentCategoryId")]
        public long? ParentCategoryId { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("uiOrderHint")]
        public long UiOrderHint { get; set; }

        [JsonProperty("medalTiers", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> MedalTiers { get; set; }
    }

}

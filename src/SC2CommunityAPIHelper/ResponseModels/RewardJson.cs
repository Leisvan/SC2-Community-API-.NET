using System;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class RewardJson
    {
        [JsonProperty("flags")]
        public long Flags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("achievementId", NullValueHandling = NullValueHandling.Ignore)]
        public string AchievementId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("unlockableType")]
        public string UnlockableType { get; set; }

        [JsonProperty("isSkin")]
        public bool IsSkin { get; set; }

        [JsonProperty("uiOrderHint")]
        public long UiOrderHint { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }
    }

}

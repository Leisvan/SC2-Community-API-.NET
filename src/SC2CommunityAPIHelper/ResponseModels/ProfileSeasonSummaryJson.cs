using Newtonsoft.Json;
using System.Collections.Generic;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class ProfileSeasonSummaryJson
    {
        [JsonProperty("seasonId")]
        public long SeasonId { get; set; }

        [JsonProperty("seasonNumber")]
        public long SeasonNumber { get; set; }

        [JsonProperty("seasonYear")]
        public long SeasonYear { get; set; }

        [JsonProperty("totalGamesThisSeason")]
        public long TotalGamesThisSeason { get; set; }

        [JsonProperty("stats")]
        public List<ProfileSeasonStatJson> Stats { get; set; }
    }
}

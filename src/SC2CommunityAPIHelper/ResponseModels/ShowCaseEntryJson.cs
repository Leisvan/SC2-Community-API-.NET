using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class ShowCaseEntryJson
    {
        [JsonProperty("ladderId")]
        public string LadderId { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }

        [JsonProperty("localizedDivisionName")]
        public string LocalizedDivisionName { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }
    }
}

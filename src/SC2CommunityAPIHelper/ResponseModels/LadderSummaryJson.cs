using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LadderSummaryJson
    {
        [JsonProperty("showCaseEntries")]
        public List<ShowCaseEntryJson> ShowCaseEntries { get; set; }

        [JsonProperty("placementMatches")]
        public List<PlacementMatchJson> PlacementMatches { get; set; }

        [JsonProperty("allLadderMemberships")]
        public List<LadderMembershipJson> AllLadderMemberships { get; set; }
    }
}

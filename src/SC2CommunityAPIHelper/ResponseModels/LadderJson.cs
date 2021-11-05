using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LadderJson
    {
        [JsonProperty("ladderTeams")]
        public List<LadderTeamJson> LadderTeams { get; set; }

        [JsonProperty("allLadderMemberships")]
        public List<LadderMembershipJson> AllLadderMemberships { get; set; }

        [JsonProperty("localizedDivision")]
        public string LocalizedDivision { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("currentLadderMembership")]
        public LadderMembershipJson CurrentLadderMembership { get; set; }

        [JsonProperty("ranksAndPools")]
        public List<RanksAndPoolJson> RanksAndPools { get; set; }
    }
}

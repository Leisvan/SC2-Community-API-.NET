using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LadderTeamsCollectionJson
    {
        [JsonProperty("ladderTeams")]
        public List<LadderTeamJson> LadderTeams
        {
            get;
            set;
        }

        public LadderTeamsCollectionJson()
        {
            LadderTeams = new List<LadderTeamJson>();
        }
    }
}

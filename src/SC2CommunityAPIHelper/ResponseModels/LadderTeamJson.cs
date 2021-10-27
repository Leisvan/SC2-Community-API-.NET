using Newtonsoft.Json;
using SC2CommunityAPI.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LadderTeamJson
    {
        [JsonProperty("teamMembers")]
        public List<TeamMemberJson> TeamMembers
        {
            get; set;
        }
        [JsonProperty("previousRank")]
        public int PreviousRank
        {
            get; private set;
        }
        [JsonProperty("points")]
        public int Points
        {
            get; private set;
        }
        [JsonProperty("wins")]
        public int Wins
        {
            get; private set;
        }
        [JsonProperty("losses")]
        public int Losses
        {
            get; private set;
        }
        [JsonProperty("mmr")]
        public int MMR
        {
            get; private set;
        }
        [JsonProperty("joinTimestamp")]
        public int JoinTimeStamp
        {
            get; private set;
        }
        public DateTime JoinDate
        {
            get => DateHelper.FormatFromStandardSeconds(JoinTimeStamp);
        }

        public LadderTeamJson()
        {
            TeamMembers = new List<TeamMemberJson>();
        }
    }
}

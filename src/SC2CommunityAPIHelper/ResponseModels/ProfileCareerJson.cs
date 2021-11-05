using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public class ProfileCareerJson
    {
        [JsonProperty("primaryRace")]
        public string PrimaryRace { get; set; }

        [JsonProperty("terranWins")]
        public long TerranWins { get; set; }

        [JsonProperty("protossWins")]
        public long ProtossWins { get; set; }

        [JsonProperty("zergWins")]
        public long ZergWins { get; set; }

        [JsonProperty("highest1v1Rank")]
        public string Highest1V1Rank { get; set; }

        [JsonProperty("highestTeamRank")]
        public string HighestTeamRank { get; set; }

        [JsonProperty("seasonTotalGames")]
        public long SeasonTotalGames { get; set; }

        [JsonProperty("careerTotalGames")]
        public long CareerTotalGames { get; set; }
    }
}

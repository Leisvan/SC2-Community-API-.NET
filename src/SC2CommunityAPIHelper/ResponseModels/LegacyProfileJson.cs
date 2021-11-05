using Newtonsoft.Json;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LegacyProfileJson
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realm")]
        public int Realm { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("clanName")]
        public string ClanName { get; set; }

        [JsonProperty("clanTag")]
        public string ClanTag { get; set; }

        [JsonProperty("profilePath")]
        public string ProfilePath { get; set; }

        [JsonProperty("portrait")]
        public PortraitJson Portrait { get; set; }

        [JsonProperty("career")]
        public ProfileCareerJson Career { get; set; }

        [JsonProperty("swarmLevels")]
        public SwarmLevelsJson SwarmLevels { get; set; }

        [JsonProperty("campaign")]
        public ProfileCampaignsFinishedJson Campaign { get; set; }

        [JsonProperty("season")]
        public ProfileSeasonSummaryJson Season { get; set; }

        [JsonProperty("rewards")]
        public ProfileRewardReferencesJson Rewards { get; set; }

        [JsonProperty("achievements")]
        public AchievementsSummaryJson Achievements { get; set; }
    }
}

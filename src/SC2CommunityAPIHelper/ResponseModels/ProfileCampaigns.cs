using Newtonsoft.Json;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class ProfileCampaignsFinishedJson
    {
        [JsonProperty("wol")]
        public string WoL { get; set; }

        [JsonProperty("hots")]
        public string HotS { get; set; }
        [JsonProperty("lotv")]
        public string LotV { get; set; }
    }
}

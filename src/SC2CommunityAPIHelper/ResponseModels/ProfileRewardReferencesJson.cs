using Newtonsoft.Json;
using System.Collections.Generic;

namespace SC2CommunityAPI.ResponseModels
{
    public class ProfileRewardReferencesJson
    {
        [JsonProperty("selected")]
        public List<string> Selected { get; set; }

        [JsonProperty("earned")]
        public List<string> Earned { get; set; }
    }
}

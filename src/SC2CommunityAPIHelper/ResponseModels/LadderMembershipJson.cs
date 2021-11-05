using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class LadderMembershipJson
    {
        [JsonProperty("ladderId")]
        public string LadderId { get; set; }

        [JsonProperty("localizedGameMode")]
        public string LocalizedGameMode { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}

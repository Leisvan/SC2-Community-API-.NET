using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class AllLadderMembership
    {
        [JsonProperty("ladderId")]
        public string LadderId { get; set; }

        [JsonProperty("localizedGameMode")]
        public string LocalizedGameMode { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}

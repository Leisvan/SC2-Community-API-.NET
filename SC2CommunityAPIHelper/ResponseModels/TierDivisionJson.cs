using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public struct TierDivisionJson
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ladder_id")]
        public int LadderId { get; set; }
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }
    }
}

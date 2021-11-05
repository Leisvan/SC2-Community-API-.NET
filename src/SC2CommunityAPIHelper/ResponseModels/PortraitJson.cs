using Newtonsoft.Json;
using System;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class PortraitJson
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}

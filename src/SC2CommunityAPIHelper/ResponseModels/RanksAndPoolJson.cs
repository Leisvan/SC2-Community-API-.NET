using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public partial class RanksAndPoolJson
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("mmr")]
        public long Mmr { get; set; }

        [JsonProperty("bonusPool")]
        public long BonusPool { get; set; }
    }
}

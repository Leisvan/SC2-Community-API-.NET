﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class Team
    {
        [JsonProperty("localizedGameMode")]
        public string LocalizedGameMode { get; set; }

        [JsonProperty("members")]
        public List<MemberJson> Members { get; set; }
    }
}

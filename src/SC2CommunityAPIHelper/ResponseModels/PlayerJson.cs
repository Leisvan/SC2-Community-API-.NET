using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public struct PlayerJson
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("profileUrl")]
        public string ProfileURL { get; private set; }
        [JsonProperty("avatarUrl")]
        public string AvatarURL { get; private set; }
        [JsonProperty("profileId")]
        public string ProfileId { get; private set; }
        [JsonProperty("regionId")]
        public int RegionId { get; private set; }
        [JsonProperty("realmId")]
        public int RealmId { get; private set; }
    }
}

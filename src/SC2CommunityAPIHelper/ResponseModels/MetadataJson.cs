using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class MetadataJson
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileUrl")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("profileId")]
        public string ProfileId { get; set; }

        [JsonProperty("regionId")]
        public long RegionId { get; set; }

        [JsonProperty("realmId")]
        public long RealmId { get; set; }
    }
}

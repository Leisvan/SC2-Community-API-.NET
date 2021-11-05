using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class TeamMemberJson
    {
        [JsonProperty("id")]
        public int Id
        {
            get; private set;
        }
        [JsonProperty("realm")]
        public int Realm
        {
            get; private set;
        }
        [JsonProperty("region")]
        public int Region
        {
            get; private set;
        }
        [JsonProperty("displayName")]
        public string DisplayName
        {
            get; private set;
        }
        [JsonProperty("clanTag")]
        public string ClanTag
        {
            get; private set;
        }
        [JsonProperty("favoriteRace")]
        public string FavoriteRace
        {
            get; private set;
        }
    }
}

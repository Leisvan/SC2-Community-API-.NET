using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2Community.ResponseModels
{
    public struct TokenJson
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; private set; }
        [JsonProperty("token_type")]
        public string TokenType { get; private set; }
        [JsonProperty("expires_in")]
        public string Expiration { get; private set; }
    }
}

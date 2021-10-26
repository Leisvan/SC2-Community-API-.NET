using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.Http
{
    public interface IOAuthCredentials
    {
        string ClientId { get; set; }
        string ClientSecret { get; set; }
    }

    public class OAuthCredentials : IOAuthCredentials
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public OAuthCredentials(string cliendId, string clientSecret)
        {
            ClientId = cliendId;
            ClientSecret = clientSecret;
        }
    }
}

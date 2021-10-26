using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.Http
{
    public class OAuthToken
    {
        public string AccessToken { get; private set; }
        public string TokenType { get; set; }
        public DateTime Expiration { get; private set; }

        public bool IsExpired => DateTime.Now >= Expiration;

        public OAuthToken(string accessToken, string tokenType, DateTime expiration)
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            Expiration = expiration;
        }
        public OAuthToken(string accessToken, string tokenType, string expirationSeconds)
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            if (!int.TryParse(expirationSeconds, out int seconds))
            {
                throw new ArgumentException(null, nameof(expirationSeconds));
            }
            Expiration = DateTime.Now + TimeSpan.FromSeconds(seconds);
        }
    }
}
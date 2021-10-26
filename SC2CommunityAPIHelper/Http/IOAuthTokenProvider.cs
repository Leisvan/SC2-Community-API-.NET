using Newtonsoft.Json;
using SC2Community.ResponseModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SC2CommunityAPI.Http
{
    public interface IOAuthTokenProvider
    {
        IOAuthCredentials Credentials { get; }
        Task<OAuthToken> GetTokenAsync();
    }

    public class OAuthTokenProvider : IOAuthTokenProvider
    {
        private const string TOKENACCESS_URL = "https://us.battle.net/oauth/token";
        private IOAuthCredentials _credentials;
        private OAuthToken _cachedToken;
        public OAuthTokenProvider(IOAuthCredentials credentials)
        {
            _credentials = credentials;
        }
        public IOAuthCredentials Credentials { get => _credentials; }

        public async Task<OAuthToken> GetTokenAsync()
        {
            if (_cachedToken == null || _cachedToken.IsExpired)
            {
                HttpClient http = new HttpClient();
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(TOKENACCESS_URL)
                };
                var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_credentials.ClientId}:{_credentials.ClientSecret}"));
                auth = string.Format("Basic {0}", auth);
                httpRequestMessage.Headers.Add("Authorization", auth);
                HttpContent httpContent = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");
                httpRequestMessage.Content = httpContent;

                try
                {
                    var reqResult = await http.SendAsync(httpRequestMessage).ConfigureAwait(false);
                    if (reqResult.IsSuccessStatusCode)
                    {
                        var contentStr = await reqResult.Content.ReadAsStringAsync();
                        var configJson = JsonConvert.DeserializeObject<TokenJson>(contentStr);
                        _cachedToken = new OAuthToken(configJson.AccessToken, configJson.TokenType, configJson.Expiration);
                    }

                }
                catch (Exception)
                {
                    _cachedToken = new OAuthToken(null, null, DateTime.Now);
                }
            }

            return _cachedToken;
        }

    }
}

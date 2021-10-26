using SC2CommunityAPI.Http;
using SC2CommunityAPI.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SC2CommunityAPI.Http
{
    public interface IWebRequestMachine
    {
        IOAuthTokenProvider TokenProvider { get; }
        IWebRequestConfiguration Configuration { get; }
        Task<HttpResponseData> GetResponseAsync(string url);
    }

    public class WebRequestMachine : IWebRequestMachine
    {
        private const string URIPARAMETER_ACCESSTOKEN = "access_token";
        private const string URIPARAMETER_ACCESSTOKEN_F = "access_token={0}";

        public IOAuthTokenProvider TokenProvider { get; private set; }
        public IWebRequestConfiguration Configuration { get; private set; }

        public WebRequestMachine(IOAuthTokenProvider tokenProvider, IWebRequestConfiguration configuration)
        {
            TokenProvider = tokenProvider;
            Configuration = configuration;
        }
        public async Task<HttpResponseData> GetResponseAsync(string url)
        {
            url = await CheckTokenConsistencyAsync(url);
            
            int retryCount = Configuration.RetryCount;
            Exception error;
            HttpResponseData data;
            do
            {
                try
                {
                    WebRequest request = WebRequest.Create(url);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = await request.GetResponseAsync()
                        .ConfigureAwait(false);
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string serverResponse = reader.ReadToEnd();

                    data = new HttpResponseData
                    {
                        Headers = response.Headers,
                        Body = serverResponse,
                    };
                    if (response is HttpWebResponse httpResponse)
                    {
                        data.StatusDescription = httpResponse.StatusDescription;
                    }

                    response.Close();
                    dataStream.Close();
                    reader.Close();
                    error = null;
                }
                catch (Exception e)
                {
                    error = e;
                    data = null;
                }
            }
            while (retryCount-- > 0 && error != null);
            return data;
        }

        private async Task<string> CheckTokenConsistencyAsync(string url)
        {
            if (!url.Contains(URIPARAMETER_ACCESSTOKEN))
            {
                var token = await TokenProvider.GetTokenAsync();
                if (string.IsNullOrWhiteSpace(token.AccessToken))
                {
                    return string.Empty;
                }
                string uriFormat = AppendAccessTokenFormat(url);
                return string.Format(uriFormat, token.AccessToken);
            }
            return url;
        }
        private string AppendAccessTokenFormat(string url)
        {
            StringBuilder builder = new StringBuilder(url);
            if (!url.EndsWith(URIPARAMETER_ACCESSTOKEN_F))
            {
                builder.Append(url.Contains("?") ? "&" : "?");
                builder.Append(URIPARAMETER_ACCESSTOKEN_F);
            }
            return builder.ToString();
        }
    }
}
﻿using SC2Community.OAuth;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SC2Community.WebRequests
{
    public interface IWebRequestMachine
    {
        Task<string> GetResponseAsync(string url);
    }

    public class WebRequestMachine : IWebRequestMachine
    {
        private const string URIPARAMETER_ACCESSTOKEN = "access_token";
        private const string URIPARAMETER_ACCESSTOKEN_F = "access_token={0}";

        private IOAuthTokenProvider _tokenProvider;
        private IWebRequestConfiguration _configuration;

        public WebRequestMachine(IOAuthTokenProvider tokenProvider, IWebRequestConfiguration configuration)
        {
            _tokenProvider = tokenProvider;
            _configuration = configuration;
        }
        public async Task<string> GetResponseAsync(string url)
        {
            if (!url.Contains(URIPARAMETER_ACCESSTOKEN))
            {
                var token = await _tokenProvider.GetTokenAsync();
                if (string.IsNullOrWhiteSpace(token.AccessToken))
                {
                    return string.Empty;
                }
                string uriFormat = AppendAccessTokenFormat(url);
                url = string.Format(uriFormat, token);
            }
            int retryCount = _configuration.RetryCount;

            Exception error;
            string serverResponse;
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

                    serverResponse = reader.ReadToEnd();

                    if (_configuration.EmptyIsError 
                        && string.IsNullOrWhiteSpace(serverResponse))
                    {
                        throw new Exception();
                    }

                    response.Close();
                    dataStream.Close();
                    reader.Close();
                    error = null;
                }
                catch (Exception e)
                {
                    serverResponse = null;
                    error = e;
                }
            }
            while (retryCount-- > 0 && error != null);
            return serverResponse;
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
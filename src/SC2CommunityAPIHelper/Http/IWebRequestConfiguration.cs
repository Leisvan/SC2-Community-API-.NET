using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.Http
{
    public interface IWebRequestConfiguration
    {
        public int RetryCount { get; }
    }

    public class WebRequestConfiguration : IWebRequestConfiguration
    {
        public int RetryCount { get; private set; }

        public WebRequestConfiguration(int retryCount = 3)
        {
            RetryCount = retryCount;
        }

    }
}

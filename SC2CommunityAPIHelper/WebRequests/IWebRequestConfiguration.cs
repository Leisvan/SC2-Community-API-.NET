using System;
using System.Collections.Generic;
using System.Text;

namespace SC2Community.WebRequests
{
    public interface IWebRequestConfiguration
    {
        public int RetryCount { get; }
        public bool EmptyIsError { get; }
    }

    public class WebRequestConfiguration : IWebRequestConfiguration
    {
        public int RetryCount { get; private set; }
        public bool EmptyIsError { get; private set; }

        public WebRequestConfiguration(int retryCount, bool emptyIsError)
        {
            RetryCount = retryCount;
            EmptyIsError = emptyIsError;
        }

    }
}

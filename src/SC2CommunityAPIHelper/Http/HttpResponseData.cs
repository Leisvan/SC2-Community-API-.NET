using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace SC2CommunityAPI.Http
{
    public class HttpResponseData
    {
        public string StatusDescription { get; set; }
        public NameValueCollection Headers { get; set; }
        public string Body { get; set; }
    }
}

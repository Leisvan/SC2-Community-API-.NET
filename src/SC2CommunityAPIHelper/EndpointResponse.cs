using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI
{
    public class EndpointResponse<T>
    {
        public string Body { get; set; }
        public string StatusDescription { get; set; }
        public T FormattedData { get; set; }
    }
}
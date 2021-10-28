using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public class APIResponse<T>
    {
        public string Body { get; set; }
        public string StatusDescription { get; set; }
        public T FormattedData { get; set; }
    }
}
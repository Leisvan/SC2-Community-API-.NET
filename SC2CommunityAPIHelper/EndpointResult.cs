using System;
using System.Collections.Generic;
using System.Text;

namespace SC2Community
{
    public class EndpointResult<T>
    {
        public T Data { get; private set; }
        public string ServerResponse { get; set; }
    }
}
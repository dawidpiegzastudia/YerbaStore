using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YerbaFrontEnd
{
    public static class SD
    {
        public static string ProductApiBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}

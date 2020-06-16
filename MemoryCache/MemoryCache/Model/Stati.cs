using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryCache.Model
{
    public class Stati
    {
        [Newtonsoft.Json.JsonProperty]
        public string name { get; set; }
        [Newtonsoft.Json.JsonProperty]
        public string capital { get; set; }
        [Newtonsoft.Json.JsonProperty]
        public int population { get; set; }


    }
}

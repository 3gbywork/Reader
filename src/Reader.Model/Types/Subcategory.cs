using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class Subcategory
    {
        //{
        //    "major": "玄幻",
        //    "mins": [
        //        "东方玄幻",
        //        "异界大陆",
        //        "异界争霸",
        //        "远古神话"
        //    ]
        //}
        [JsonProperty("major")]
        public String Major { get; set; }

        [JsonProperty("mins")]
        public IList<String> Mins { get; set; }
    }
}

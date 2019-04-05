using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class Rating
    {
        //    {
        //        "count": 40945,
        //        "score": 8.634,
        //        "isEffect": true
        //    }

        [JsonProperty("count")]
        public Int32 Count { get; set; }

        [JsonProperty("score")]
        public Single Score { get; set; }

        [JsonProperty("isEffect")]
        public Boolean IsEffect { get; set; }
    }
}

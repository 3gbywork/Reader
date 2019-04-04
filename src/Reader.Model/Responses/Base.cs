using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Responses
{
    public class Base
    {
        [JsonProperty("ok")]
        public Boolean OK { get; set; }
    }
}

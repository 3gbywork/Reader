using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class SearchHotwords : Base
    {
        [JsonProperty("searchHotWords")]
        public Hotwords HotWords { get; set; }
    }

    public class Hotwords : BaseList<Hotword>
    {

    }

    public class Hotword
    {
        public String Word { get; set; }
        public Int32 Times { get; set; }
        public Int32 IsNew { get; set; }
        public Int32 Soaring { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class SearchHotWords : Base
    {
        [JsonProperty("searchHotWords")]
        public HotWords HotWords { get; set; }
    }

    public class HotWords : BaseList<HotWord>
    {

    }

    public class HotWord
    {
        public String Word { get; set; }
        public Int32 Times { get; set; }
        public Int32 IsNew { get; set; }
        public Int32 Soaring { get; set; }
    }
}

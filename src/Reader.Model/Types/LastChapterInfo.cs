using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class LastChapterInfo
    {
        [JsonProperty("_id")]
        public String ID { get; set; }

        public String Author { get; set; }
        public Boolean IsMakeMoneyLimit { get; set; }
        public Boolean IsFineBook { get; set; }
        public Boolean AllowMonthly { get; set; }
        public String ReferenceSource { get; set; }
        public DateTime Updated { get; set; }
        public Int32 ChaptersCount { get; set; }
        public String LastChapter { get; set; }
    }

    public class LastChapterInfos : BaseList<LastChapterInfo>
    {

    }
}

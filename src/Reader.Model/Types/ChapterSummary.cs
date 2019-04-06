using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class ChapterSummary : Base
    {
        //{
        //    "mixToc": {
        //        "_id": "567d62973d43be74aab502c6",
        //        "chaptersCount1": 508,
        //        "book": "567d2cb9ee0e56bc713cb2c0",
        //        "chaptersUpdated": "2017-11-25T05:32:06.997Z",
        //        "chapters": [],
        //        "updated": "2018-02-10T17:09:00.088Z"
        //    },
        //    "ok": true
        //}

        /// <summary>
        /// 章节摘要
        /// </summary>
        public MixToc MixToc { get; set; }
    }

    public class MixToc
    {
        public String ID { get; set; }
        public Int32 ChaptersCount1 { get; set; }
        public String Book { get; set; }
        public DateTime ChaptersUpdated { get; set; }
        public Chapters Chapters { get; set; }
        public DateTime Updated { get; set; }
    }
}

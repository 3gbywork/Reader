using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class ChapterSummaryEx
    {
        //{
        //    "_id": "579b93b0561763dd2d2382ea",
        //    "name": "落秋中文",
        //    "chaptersCount1": 517,
        //    "lastChapter1": "第五百零二章 五行考验",
        //    "source": "luoqiu",
        //    "book": "567d2cb9ee0e56bc713cb2c0",
        //    "link": "http://www.luoqiu.com/read/22132/",
        //    "chapters": [],
        //    "updated": "2017-03-01T05:07:31.309Z",
        //    "host": "luoqiu.com"
        //}

        public String ID { get; set; }
        public String Name { get; set; }
        public Int32 ChaptersCount1 { get; set; }
        public String LastChapter1 { get; set; }
        public String Source { get; set; }
        public String Book { get; set; }
        public String Link { get; set; }
        public ChaptersEx Chapters { get; set; }
        public DateTime Updated { get; set; }
        public String Host { get; set; }
    }
}

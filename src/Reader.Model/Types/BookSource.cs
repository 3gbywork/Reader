using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BookSource
    {
        //{
        //"_id": "56f8da09176d03ac1983f6cd",
        //"name": "优质书源",
        //"lastChapter": "第1110章 飞升之劫",
        //"source": "zhuishuvip",
        //"link": "http://vip.zhuishushenqi.com/toc/56f8da09176d03ac1983f6cd",
        //"isCharge": false,
        //"chaptersCount": 1110,
        //"updated": "2019-03-20T08:51:15.445Z",
        //"starting": true,
        //"host": "vip.zhuishushenqi.com"
        //}

        public String ID { get; set; }
        public String Name { get; set; }
        public String LastChapter { get; set; }
        public String Source { get; set; }
        public String Link { get; set; }
        public Boolean IsCharge { get; set; }
        public Int32 ChaptersCount { get; set; }
        public DateTime Updated { get; set; }
        public Boolean Starting { get; set; }
        public String Host { get; set; }
    }

    public class BookSources : BaseList<BookSource>
    {

    }
}

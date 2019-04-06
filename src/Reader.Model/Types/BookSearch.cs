using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BookSearch : BookBrief
    {
        //{
        //    "_id": "540e40b78a909efb05d33503",
        //    "hasCp": true,
        //    "title": "逆袭万岁",
        //    "aliases": "",
        //    "cat": "都市",
        //    "author": "霞飞双颊",
        //    "site": "zhuishuvip",
        //    "cover": "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F62091%2F62091_0adb3525902c4a47aa1e40ca7ca3ea2a_default_cover.png%2F",
        //    "shortIntro": "简介： 林东做了一个梦，他梦见自己穿越了，还在一个奇妙的修真世界里游荡了十年。梦醒，却惊而发现这是真的。在修真世界混很苦逼一直是战五渣般存在的林东同学，在现代都市里，他发现自己简直无所不能，逆袭白富美什么的，真心不要太容易！",
        //    "lastChapter": "第1001章 大结局！也是新的开始！",
        //    "retentionRatio": 27.65,
        //    "banned": 0,
        //    "allowMonthly": false,
        //    "latelyFollower": 455,
        //    "wordCount": 3813388,
        //    "contentType": "txt",
        //    "superscript": "",
        //    "sizetype": -1,
        //    "highlight": {
        //        "author": [
        //            "霞",
        //            "飞"
        //        ]
        //    }
        //}

        public Boolean HasCp { get; set; }
        public String Aliases { get; set; }
        public String Cat { get; set; }
        public Int32 WordCount { get; set; }
        public String Superscript { get; set; }
        public Int32 Sizetype { get; set; }
        public Highlight Highlight { get; set; }
    }

    public class Highlight
    {
        public IList<String> Author { get; set; }
    }
}

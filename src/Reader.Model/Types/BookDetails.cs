using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BookDetails : BookBrief
    {
        //{
        ////    "_id": "59ba0dbb017336e411085a4e",
        //    "longIntro": "彼时的归途，已是一条命运倒悬的路。\r\n昔日的荣华，如白云苍狗，恐大梦一场。\r\n少年执笔，龙蛇飞动。\r\n是为一抹光芒劈开暮气沉沉之乱世，问鼎玉宇苍穹。\r\n \r\n复仇之路，与吾同行。\r\n一口玄黄真气定可吞天地日月星辰，雄视草木苍生。\r\n \r\n铁画夕照，雾霭银钩，笔走游龙冲九州。\r\n横姿天下，墨洒青山，鲸吞湖海纳百川。",
        ////    "title": "元尊",
        ////    "majorCate": "玄幻",
        //    "minorCateV2": "东方玄幻",
        //    "creater": "OnePlus ONEPLUS A5000",
        ////    "minorCate": "东方玄幻",
        ////    "author": "天蚕土豆",
        ////    "cover": "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F2107590%2F2107590_3462cef8f0b9444bb8e827aa39b56ffc.jpg%2F",
        //    "majorCateV2": "玄幻",
        //    "isFineBook": false,
        //    "safelevel": 0,
        //    "allowFree": false,
        //    "originalAuthor": "",
        //    "anchors": [],
        //    "authorDesc": "",
        //    "rating": {
        //        "count": 40945,
        //        "score": 8.634,
        //        "isEffect": true
        //    },
        //    "hasCopyright": true,
        //    "buytype": 0,
        ////    "sizetype": -1,
        ////    "superscript": "",
        //    "currency": 0,
        ////    "contentType": "txt",
        //    "_le": false,
        ////    "allowMonthly": false,
        //    "allowVoucher": true,
        //    "allowBeanVoucher": true,
        //    "hasCp": true,
        ////    "banned": 0,
        //    "postCount": 21258,
        ////    "latelyFollower": 119001,
        //    "followerCount": 0,
        //    "wordCount": 2031406,
        //    "serializeWordCount": 4534,
        ////    "retentionRatio": "68.12",
        //    "updated": "2019-04-04T13:04:40.796Z",
        //    "isSerial": true,
        //    "chaptersCount": 806,
        ////    "lastChapter": "正文 第八百零一章 风母纹",
        //    "gender": [
        //        "male"
        //    ],
        ////    "tags": [
        ////        "东方玄幻",
        ////        "争霸流",
        ////        "坚毅",
        ////        "天蚕土豆",
        ////        "热血",
        ////        "爽文",
        ////        "玄幻"
        ////    ],
        //    "advertRead": true,
        //    "cat": "东方玄幻",
        //    "donate": false,
        //    "_gg": false,
        //    "isForbidForFreeApp": false,
        //    "isAllowNetSearch": false,
        //    "limit": false,
        //    "copyrightDesc": "本书由上海元聚进行电子本制作与发行",
        //    "discount": null
        //}

        [JsonProperty("longIntro")]
        public new String Intro { get; set; }

        [JsonProperty("minorCateV2")]
        public String MinorCateV2 { get; set; }

        [JsonProperty("creater")]
        public String Creater { get; set; }

        [JsonProperty("majorCateV2")]
        public String MajorCateV2 { get; set; }

        [JsonProperty("isFineBook")]
        public Boolean IsFineBook { get; set; }

        [JsonProperty("safelevel")]
        public Int32 SafeLevel { get; set; }

        [JsonProperty("allowFree")]
        public Boolean AllowFree { get; set; }

        [JsonProperty("originalAuthor")]
        public String OriginalAuthor { get; set; }

        [JsonProperty("anchors")]
        public IList<String> Anchors { get; set; }

        [JsonProperty("authorDesc")]
        public String AuthorDesc { get; set; }

        [JsonProperty("rating")]
        public Rating Rating { get; set; }

        [JsonProperty("hasCopyright")]
        public Boolean HasCopyright { get; set; }

        [JsonProperty("buytype")]
        public Int32 BuyType { get; set; }

        [JsonProperty("currency")]
        public Int32 Currency { get; set; }

        [JsonProperty("_le")]
        public Boolean Le { get; set; }

        [JsonProperty("allowVoucher")]
        public Boolean AllowVoucher { get; set; }

        [JsonProperty("allowBeanVoucher")]
        public Boolean AllowBeanVoucher { get; set; }

        [JsonProperty("hasCp")]
        public Boolean HasCp { get; set; }

        [JsonProperty("postCount")]
        public Int32 PostCount { get; set; }

        [JsonProperty("followerCount")]
        public Int32 FollowerCount { get; set; }

        [JsonProperty("wordCount")]
        public Int32 WordCount { get; set; }

        [JsonProperty("serializeWordCount")]
        public Int32 SerializeWordCount { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("isSerial")]
        public Boolean IsSerial { get; set; }

        [JsonProperty("chaptersCount")]
        public Int32 ChaptersCount { get; set; }

        [JsonProperty("gender")]
        public IList<String> Gender { get; set; }

        [JsonProperty("advertRead")]
        public Boolean AdvertRead { get; set; }

        [JsonProperty("cat")]
        public String Category { get; set; }

        [JsonProperty("donate")]
        public Boolean Donate { get; set; }

        [JsonProperty("_gg")]
        public Boolean Gg { get; set; }

        [JsonProperty("isForbidForFreeApp")]
        public Boolean IsForbidForFreeApp { get; set; }

        [JsonProperty("isAllowNetSearch")]
        public Boolean IsAllowNetSearch { get; set; }

        [JsonProperty("limit")]
        public Boolean Limit { get; set; }

        [JsonProperty("copyrightDesc")]
        public String CopyrightDesc { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [JsonProperty("discount")]
        public String Discount { get; set; }
    }

    public class Rating
    {
        [JsonProperty("count")]
        public Int32 Count { get; set; }

        [JsonProperty("score")]
        public Single Score { get; set; }

        [JsonProperty("isEffect")]
        public Boolean IsEffect { get; set; }
    }
}

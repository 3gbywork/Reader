using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BookBase
    {
        //{
        //    "_id": "59ba0dbb017336e411085a4e",
        //    "title": "元尊",
        //    "majorCate": "玄幻",
        //    "minorCate": "东方玄幻",
        //    "author": "天蚕土豆",
        //    "cover": "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F2107590%2F2107590_3462cef8f0b9444bb8e827aa39b56ffc.jpg%2F",
        //    "sizetype": -1,
        //    "superscript": "",
        //    "contentType": "txt",
        //    "allowMonthly": false,
        //    "banned": 0,
        //    "latelyFollower": 119001,
        //    "retentionRatio": 68.12,
        //    "lastChapter": "正文 第八百零一章 风母纹",
        //    "tags": [
        //        "东方玄幻",
        //        "争霸流",
        //        "坚毅",
        //        "天蚕土豆",
        //        "热血",
        //        "爽文",
        //        "玄幻"
        //    ]
        //}

        [JsonProperty("_id")]
        public String ID { get; set; }

        [JsonProperty("author")]
        public String Author { get; set; }

        [JsonProperty("majorCate")]
        public String MajorCate { get; set; }

        [JsonProperty("minorCate")]
        public String MinorCate { get; set; }

        [JsonProperty("title")]
        public String Title { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        [JsonProperty("cover")]
        public String Cover { get; set; }

        [JsonProperty("sizetype")]
        public Int32 SizeType { get; set; }

        [JsonProperty("superscript")]
        public String SuperScript { get; set; }

        [JsonProperty("contentType")]
        public String ContentType { get; set; }

        [JsonProperty("allowMonthly")]
        public Boolean AllowMonthly { get; set; }

        [JsonProperty("banned")]
        public Int32 Banned { get; set; }

        [JsonProperty("latelyFollower")]
        public Int32 LatelyFollower { get; set; }

        [JsonProperty("retentionRatio")]
        public Single RetentionRatio { get; set; }

        [JsonProperty("lastChapter")]
        public String LastChapter { get; set; }

        [JsonProperty("tags")]
        public IList<String> Tags { get; set; }
    }
}

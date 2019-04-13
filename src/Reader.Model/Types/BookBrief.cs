using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BookBrief : BookBase
    {
        //{
        ////    "_id": "59ba0dbb017336e411085a4e",
        ////    "title": "元尊",
        ////    "majorCate": "玄幻",
        //    "shortIntro": "彼时的归途，已是一条命运倒悬的路。\r\n昔日的荣华，如白云苍狗，恐大梦一场。\r\n少年执笔，龙蛇飞动。\r\n是为一抹光芒劈开暮气沉沉之乱世，问鼎玉宇苍穹。\r\n \r\n复仇之路，与吾同行。\r\n一口玄黄真气定可吞天地日月星辰，雄视草木苍生。\r\n \r\n铁画夕照，雾霭银钩，笔走游龙冲九州。\r\n横姿天下，墨洒青山，鲸吞湖海纳百川。",
        ////    "minorCate": "东方玄幻",
        //    "site": "zhuishuvip",
        ////    "author": "天蚕土豆",
        ////    "cover": "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F2107590%2F2107590_3462cef8f0b9444bb8e827aa39b56ffc.jpg%2F",
        ////    "sizetype": -1,
        ////    "superscript": "",
        ////    "contentType": "txt",
        ////    "allowMonthly": false,
        ////    "banned": 0,
        ////    "latelyFollower": 119001,
        ////    "retentionRatio": 68.12,
        ////    "lastChapter": "正文 第八百零一章 风母纹",
        ////    "tags": [
        ////        "东方玄幻",
        ////        "争霸流",
        ////        "坚毅",
        ////        "天蚕土豆",
        ////        "热血",
        ////        "爽文",
        ////        "玄幻"
        ////    ]
        //}

        [JsonProperty("sizetype")]
        public Int32 SizeType { get; set; }

        [JsonProperty("superscript")]
        public String SuperScript { get; set; }

        [JsonProperty("contentType")]
        public String ContentType { get; set; }

        [JsonProperty("lastChapter")]
        public String LastChapter { get; set; }

        [JsonProperty("tags")]
        public IList<String> Tags { get; set; }
    }
}

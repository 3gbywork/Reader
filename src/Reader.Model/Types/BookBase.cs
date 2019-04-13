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
        //    "_id": "55eef8b27445ad27755670b9",
        //    "cover": "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F857368%2F857368_8428516582234635819871b0dd5862e7.jpg%2F",
        //    "site": "zhuishuvip",
        //    "author": "圣骑士的传说",
        //    "majorCate": "都市",
        //    "minorCate": "异术超能",
        //    "title": "修真聊天群",
        //    "shortIntro": "某天，宋书航意外加入了一个仙侠中二病资深患者的交流群，里面的群友们都以‘道友’相称，群名片都是各种府主、洞主、真人、天师。连群主走失的宠物犬都称为大妖犬离家出走。整天聊的是炼丹、闯秘境、炼功经验啥的。\r\n突然有一天，潜水良久的他突然发现……群里每一个群员，竟然全部是修真者，能移山倒海、长生千年的那种！\r\n啊啊啊啊，世界观在一夜间彻底崩碎啦！",
        //    "allowMonthly": false,
        //    "banned": 0,
        //    "latelyFollower": 130032,
        //    "retentionRatio": "79.04"
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

        [JsonProperty("allowMonthly")]
        public Boolean AllowMonthly { get; set; }

        [JsonProperty("banned")]
        public Int32 Banned { get; set; }

        [JsonProperty("latelyFollower")]
        public Int32 LatelyFollower { get; set; }

        [JsonProperty("retentionRatio")]
        public Single RetentionRatio { get; set; }

        [JsonProperty("site")]
        public String Site { get; set; }

        /// <summary>
        /// shortIntro/longIntro
        /// </summary>
        [JsonProperty("shortIntro")]
        public String Intro { get; set; }
    }
}

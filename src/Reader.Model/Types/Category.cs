using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class Category
    {
        //{
        //    "name": "玄幻",
        //    "bookCount": 578130,
        //    "monthlyCount": 21638,
        //    "icon": "/icon/玄幻_.png",
        //    "bookCover": [
        //        "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F1228859%2F1228859_b7114fbfc2a44969ac2879fcec1d6bea.jpg%2F",
        //        "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F2107590%2F2107590_3462cef8f0b9444bb8e827aa39b56ffc.jpg%2F",
        //        "/agent/http%3A%2F%2Fimg.1391.com%2Fapi%2Fv1%2Fbookcenter%2Fcover%2F1%2F41584%2F41584_873f1d8b2f7a447a8c59f3573094db1b.jpg%2F"
        //    ]
        //}
        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("bookCount")]
        public Int32 BookCount { get; set; }

        //public Int32 MonthlyCount { get; set; }
        //public String Icon { get; set; }
        //public IList<String> BookCover { get; set; }
    }
}

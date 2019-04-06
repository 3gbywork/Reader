using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class RankingGender : Base
    {
        //{
        //    "male": [
        //        {
        //            "_id": "54d42d92321052167dfb75e3",
        //            "title": "追书最热榜 Top100",
        //            "cover": "/ranking-cover/142319144267827",
        //            "collapse": false,
        //            "monthRank": "564d820bc319238a644fb408",
        //            "totalRank": "564d8494fe996c25652644d2",
        //            "shortTitle": "最热榜"
        //        }
        //    ],
        //    "female": [],
        //    "picture": [],
        //    "epub": [],
        //    "ok": true
        //}

        public IList<Ranking> Male { get; set; }
        public IList<Ranking> Female { get; set; }
        public IList<Ranking> Picture { get; set; }
        public IList<Ranking> Epub { get; set; }
    }

    public class Ranking
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public bool Collapse { get; set; }
        public string MonthRank { get; set; }
        public string TotalRank { get; set; }
        public string ShortTitle { get; set; }
    }
}

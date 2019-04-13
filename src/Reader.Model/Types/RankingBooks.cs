using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class RankingBooks : Base
    {
        public RankingDetail Ranking { get; set; }
    }

    public class RankingDetail
    {
        public String _id { get; set; }
        public DateTime Updated { get; set; }
        public String Title { get; set; }
        public String Tag { get; set; }
        public String Cover { get; set; }
        public String Icon { get; set; }
        public Int32 __v { get; set; }
        public String MonthRank { get; set; }
        public String TotalRank { get; set; }
        public String ShortTitle { get; set; }
        public DateTime Created { get; set; }
        public String BiTag { get; set; }
        public Boolean IsSub { get; set; }
        public Boolean Collapse { get; set; }
        public Boolean _new { get; set; }
        public String Gender { get; set; }
        public Int32 Priority { get; set; }
        public IList<BookBase> Books { get; set; }
        public String ID { get; set; }
        public Int32 Total { get; set; }
    }
}

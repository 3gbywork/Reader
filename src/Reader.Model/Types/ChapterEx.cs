using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class ChapterEx : Chapter
    {
        //{
        //    "link": "http://www.luoqiu.com/read/22132/5789514.html",
        //    "title": "序章",
        //    "time": 0,
        //    "chapterCover": "",
        //    "totalpage": 0,
        //    "partsize": 0,
        //    "order": 0,
        //    "currency": 0,
        //    "unreadble": false,
        //    "isVip": false
        //}

        public Int32 Time { get; set; }
        public String ChapterCover { get; set; }
        public Int32 Totalpage { get; set; }
        public Int32 Partsize { get; set; }
        public Int32 Order { get; set; }
        public Int32 Currency { get; set; }
        public Boolean IsVip { get; set; }
    }

    public class ChaptersEx : BaseList<ChapterEx>
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class Chapter
    {
        //{
        //    "link": "http://book.my716.com/getBooks.aspx?method=content&bookId=872129&chapterFile=U_872129_201707191551460647_7199_1.txt",
        //    "title": "第1章 序章",
        //    "unreadble": false
        //}

        public String Link { get; set; }
        public String Title { get; set; }
        public Boolean Unreadble { get; set; }
    }

    public class Chapters : BaseList<Chapter>
    {

    }
}

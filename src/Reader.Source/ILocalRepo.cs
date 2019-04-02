using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Source
{
    interface ILocalRepo
    {
        /// <summary>
        /// 获取书架书籍
        /// </summary>
        /// <returns></returns>
        IList<IBook> ListBookself();
    }
}

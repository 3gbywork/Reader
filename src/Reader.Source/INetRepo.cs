using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Source
{
    interface INetRepo
    {
        /// <summary>
        /// 搜索书籍
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IList<IBook> Search(String name);
        /// <summary>
        /// 获取分类书籍
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        IList<IBook> ListCategory(String category);
        /// <summary>
        /// 获取推荐榜
        /// </summary>
        /// <param name="hot"></param>
        /// <returns></returns>
        IList<IBook> ListHot(String hot);
    }
}

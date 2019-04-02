using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model
{
    public class Chapter
    {
        /// <summary>
        /// ID
        /// </summary>
        public Int32 ID { get; set; }
        /// <summary>
        /// BookID
        /// </summary>
        public Int32 BookID { get; set; }
        /// <summary>
        /// 章节序号
        /// </summary>
        public Int32 Serial { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// 段落
        /// </summary>
        public IList<String> Sections { get; set; }
    }
}

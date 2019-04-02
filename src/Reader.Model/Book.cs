using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model
{
    public class Book
    {
        /// <summary>
        /// ID
        /// </summary>
        public Int32 ID { get; set; }
        /// <summary>
        /// 封面
        /// </summary>
        public Uri Cover { get; set; }
        /// <summary>
        /// 首页
        /// </summary>
        public Uri Home { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public String Author { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public String Introduction { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public String Category { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public String Status { get; set; }
    }
}

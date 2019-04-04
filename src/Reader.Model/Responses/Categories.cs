using Newtonsoft.Json;
using Reader.Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Responses
{
    public class Categories : Base
    {
        /// <summary>
        /// 男生
        /// </summary>
        [JsonProperty("male")]
        public IList<Category> Male { get; set; }

        /// <summary>
        /// 女生
        /// </summary>
        [JsonProperty("female")]
        public IList<Category> Female { get; set; }

        /// <summary>
        /// 漫画
        /// </summary>
        [JsonProperty("picture")]
        public IList<Category> Picture { get; set; }

        /// <summary>
        /// 出版
        /// </summary>
        [JsonProperty("press")]
        public IList<Category> Press { get; set; }
    }
}

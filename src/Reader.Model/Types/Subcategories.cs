using Newtonsoft.Json;
using Reader.Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class Subcategories : Base
    {
        //{
        //    "male": [],
        //    "female": [],
        //    "picture": [],
        //    "press": [],
        //    "ok": true
        //}

        /// <summary>
        /// 男生
        /// </summary>
        [JsonProperty("male")]
        public IList<Subcategory> Male { get; set; }

        /// <summary>
        /// 女生
        /// </summary>
        [JsonProperty("female")]
        public IList<Subcategory> Female { get; set; }

        /// <summary>
        /// 漫画
        /// </summary>
        [JsonProperty("picture")]
        public IList<Subcategory> Picture { get; set; }

        /// <summary>
        /// 出版
        /// </summary>
        [JsonProperty("press")]
        public IList<Subcategory> Press { get; set; }
    }
}

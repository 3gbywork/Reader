using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Source.Zhuishushenqi
{
    class Constant
    {
        public const String ApiServer = "http://api05iye5.zhuishushenqi.com";//"http://api.zhuishushenqi.com";
        public const String PictureServer = "http://statics.zhuishushenqi.com";
        public const String ChapterServer = "http://chapterup.zhuishushenqi.com";

        // Query String
        public const String BaseUrl = ApiServer;
        public const String Category = BaseUrl + "/cats/lv2/statistics";
        public const String Subcategory = BaseUrl + "/cats/lv2";
        public const String BooksByCategory = BaseUrl + "/book/by-categories";
        public const String BookDetail = BaseUrl + "/book";
        public const String BookSourceA = BaseUrl + "/atoc";
        public const String BookSourceB = BaseUrl + "/btoc";
        public const String Chapter = BaseUrl + "/mix-atoc";
        public const String ChapterEx = BaseUrl + "/atoc";
        public const String ChapterDetail = ChapterServer + "/chapter";
        public const String Search = BaseUrl + "/book/fuzzy-search";
        public const String RankingGender = BaseUrl + "/ranking/gender";
        public const String BooksByRanking = BaseUrl + "/ranking";
        public const String SearchHotwords = BaseUrl + "/book/search-hotwords";
        public const String AutoComplete = BaseUrl + "/book/auto-complete";
    }
}

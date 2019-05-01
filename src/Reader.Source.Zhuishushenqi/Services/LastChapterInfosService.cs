using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class LastChapterInfosService : ILastChapterInfosService
    {
        public Task<LastChapterInfos> GetLastChapterInfosAsync(string bookID)
        {
            var args = new Dictionary<String, String>
            {
                {"view", "updated" },
                {"id", bookID }
            };
            return DefaultHttpUtility.GetAsync<LastChapterInfos>(Constant.BookDetail, args);
        }
    }
}

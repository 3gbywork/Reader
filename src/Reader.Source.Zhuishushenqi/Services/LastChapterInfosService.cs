using Reader.Model.Types;
using Reader.Source.Services;
using Reader.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return HttpUtility.GetAsync<LastChapterInfos>(Constant.BookDetail, args);
        }
    }
}

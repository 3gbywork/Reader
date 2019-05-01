using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class ChapterSummaryService : IChapterSummaryService
    {
        public Task<ChapterSummary> GetChaptersAsync(string bookID)
        {
            var args = new Dictionary<String, String>
            {
                {"view", "chapters" }
            };
            return DefaultHttpUtility.GetAsync<ChapterSummary>($"{Constant.Chapter}/{bookID}", args);
        }
    }
}

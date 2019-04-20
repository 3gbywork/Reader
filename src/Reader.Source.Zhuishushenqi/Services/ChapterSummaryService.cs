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
    public class ChapterSummaryService : IChapterSummaryService
    {
        public Task<ChapterSummary> GetChaptersAsync(string bookID)
        {
            var args = new Dictionary<String, String>
            {
                {"view", "chapters" }
            };
            return HttpUtility.GetAsync<ChapterSummary>($"{Constant.Chapter}/{bookID}", args);
        }
    }
}

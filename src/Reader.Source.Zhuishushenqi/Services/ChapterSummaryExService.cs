using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class ChapterSummaryExService : IChapterSummaryExService
    {
        public Task<ChapterSummaryEx> GetChapterSummaryExAsync(string sourceID)
        {
            var args = new Dictionary<String, String>
            {
                {"view", "chapters" }
            };
            return DefaultHttpUtility.GetAsync<ChapterSummaryEx>($"{Constant.ChapterEx}/{sourceID}", args);
        }
    }
}

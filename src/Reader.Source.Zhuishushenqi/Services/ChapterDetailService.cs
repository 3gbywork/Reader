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
    public class ChapterDetailService : IChapterDetailService
    {
        public Task<ChapterDetails> GetChapterDetailsAsync(String url)
        {
            //正版书源获取章节方式
            return HttpUtility.GetAsync<ChapterDetails>($"{Constant.ChapterDetail}/{url}");
        }
    }
}

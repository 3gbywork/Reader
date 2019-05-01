using Reader.Model.Types;
using Reader.Source.Services;
using System;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Services
{
    public class ChapterDetailService : IChapterDetailService
    {
        public Task<ChapterDetails> GetChapterDetailsAsync(String url)
        {
            //正版书源获取章节方式
            return DefaultHttpUtility.GetAsync<ChapterDetails>($"{Constant.ChapterDetail}/{url}");
        }
    }
}

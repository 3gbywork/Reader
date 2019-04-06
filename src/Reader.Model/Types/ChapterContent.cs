using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class ChapterContent
    {
        //    {
        //        "title": "第1章 序章",
        //        "body": "\n\r\n\r\n\r请安装最新版追书 以便使用优质资源",
        //        "isVip": false,
        //        "cpContent": "　　浩瀚宇宙某个偏僻星域中，一点朦胧金光以某种固定速度在漆黑星空中徐徐飞行着，并不时从中传出阵阵啼鸣之声，若断若续，若有若无，仿佛泣血之音，又如九幽狞笑。\n\n　　不知过了多少年后，前方蓦然出现一颗蔚蓝色巨大星球。\n\n　　“轰”的一声巨响！\n\n　　金光在星球引力作用下，以惊人速度向巨大星球直冲而去，并在接触星球表面大气的瞬间，化为一团汹汹燃烧流星，向下方一片海域坠落而去。\n\n　　……\n\n　　大齐天元九年，有灵官上禀朝廷，有天外异物落入东海之内，化为滔天巨浪淹没二十余岛屿，越府沿海数县被巨浪波及，毁房屋万间，百姓家畜死伤无数——《东洲记》\n\n\n\n",
        //        "currency": 0,
        //        "id": "56f8da09176d03ac1983f6d7"
        //    }

        public String Title { get; set; }
        public String Body { get; set; }
        public Boolean IsVip { get; set; }
        public String CpContent { get; set; }
        public Int32 Currency { get; set; }
        public String ID { get; set; }
    }
}

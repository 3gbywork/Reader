using Reader.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.Zhuishushenqi.Test.Global
{
    class ApiClient
    {
        private static HttpUtility httpUtil;

        public static HttpUtility HttpUtility
        {
            get
            {
                if (null == httpUtil)
                    httpUtil = new HttpUtility(new Reader.Source.ApiClient.ApiClient());
                return httpUtil;
            }
        }
    }
}

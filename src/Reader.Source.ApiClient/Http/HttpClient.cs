using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.ApiClient.Http
{
    public class HttpClient : IHttp
    {
        private readonly System.Net.Http.HttpClient httpClient;

        public HttpClient()
        {
            httpClient = new System.Net.Http.HttpClient();
        }

        public async Task<String> GetAsync(string requestUri, IDictionary<string, string> args)
        {
            var url = requestUri;

            if (null != args)
            {
                System.Net.Http.HttpContent httpContent = new System.Net.Http.FormUrlEncodedContent(args);
                var content = await httpContent.ReadAsStringAsync();

                url = string.Concat(url, "?", content);
            }
            return await httpClient.GetStringAsync(url);
        }
    }
}

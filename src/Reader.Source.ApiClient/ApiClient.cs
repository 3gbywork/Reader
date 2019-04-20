using Reader.Source.ApiClient.Http;
using Reader.Source.ApiClient.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Source.ApiClient
{
    public class ApiClient : IApiClient
    {
        private IHttp httpClient;
        private ISerializer serializer;

        public ApiClient()
        {

            UseHttp<HttpClient>();
            UseSerializer<JsonSerializer>();
        }

        private void UseSerializer<T>() where T : ISerializer, new()
        {
            serializer = new T();
        }

        private void UseHttp<T>() where T : IHttp, new()
        {
            httpClient = new T();
        }

        public Task<T> GetAsync<T>(string requestUri)
        {
            return GetAsync<T>(requestUri, null);
        }

        public async Task<T> GetAsync<T>(string requestUri, IDictionary<string, string> args)
        {
            return await await httpClient.GetAsync(requestUri, args).ContinueWith(async t =>
            {
                var value = await t;
                return serializer.Deserialize<T>(value);
            });
        }
    }
}

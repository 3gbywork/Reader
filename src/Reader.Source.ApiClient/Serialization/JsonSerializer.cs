using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Source.ApiClient.Serialization
{
    public class JsonSerializer : ISerializer
    {
        public T Deserialize<T>(string content)
        {
            return JsonConvert.DeserializeObject<T>(content);
        }

        public string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}

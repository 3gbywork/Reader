using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Source.ApiClient.Serialization
{
    public interface ISerializer
    {
        string Serialize(object value);

        T Deserialize<T>(String content);
    }
}

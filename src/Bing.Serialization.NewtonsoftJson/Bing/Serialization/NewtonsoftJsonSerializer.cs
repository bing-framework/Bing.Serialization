using System;
using System.Threading.Tasks;
using Bing.Serialization.Json.Newtonsoft;
using Newtonsoft.Json;

namespace Bing.Serialization
{
    /// <summary>
    /// Newtonsoft Json 序列化器
    /// </summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        /// <summary>
        /// Json序列化设置
        /// </summary>
        private readonly JsonSerializerSettings _settings;

        public NewtonsoftJsonSerializer()
        {

        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T">序列化对象类型</typeparam>
        /// <param name="o">被序列化对象</param>
        public string Serialize<T>(T o) => JsonHelper.Serialize(o);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">被序列化对象类型</typeparam>
        /// <param name="data">被反序列化对象</param>
        public T Deserialize<T>(string data) => JsonHelper.Deserialize<T>(data);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="data">被反序列化对象</param>
        /// <param name="type">被序列化对象类型</param>
        public object Deserialize(string data, Type type) => JsonHelper.Deserialize(data, type);

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T">序列化对象类型</typeparam>
        /// <param name="o">被序列化对象</param>
        public async Task<string> SerializeAsync<T>(T o) => await JsonHelper.SerializeAsync(o);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">被序列化对象类型</typeparam>
        /// <param name="data">被反序列化对象</param>
        public async Task<T> DeserializeAsync<T>(string data) => await JsonHelper.DeserializeAsync<T>(data);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="data">被反序列化对象</param>
        /// <param name="type">被序列化对象类型</param>
        public async Task<object> DeserializeAsync(string data, Type type) => await JsonHelper.DeserializeAsync(data, type);
    }
}

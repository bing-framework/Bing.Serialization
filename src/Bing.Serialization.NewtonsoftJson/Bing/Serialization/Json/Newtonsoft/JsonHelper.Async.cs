using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bing.Serialization.Json.Newtonsoft
{
    /// <summary>
    /// Json操作辅助类
    /// </summary>
    public static partial class JsonHelper
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="o">序列化对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<byte[]> SerializeToBytesAsync(object o, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            o is null
                ? new byte[0]
                : JsonManager.DefaultEncoding.GetBytes(await SerializeAsync(o, settings, withNodaTime));

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="o">序列化对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<string> SerializeAsync(object o, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            o is null
                ? string.Empty
                : await Task.Run(() => JsonConvert.SerializeObject(o, TouchSettings(settings, withNodaTime)));

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="data">数据</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<T> DeserializeFromBytesAsync<T>(byte[] data, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            data is null || data.Length is 0
                ? default
                : await DeserializeAsync<T>(JsonManager.DefaultEncoding.GetString(data), settings, withNodaTime);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="type">类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<object> DeserializeFromBytesAsync(byte[] data, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            data is null || data.Length is 0
                ? default
                : await DeserializeAsync(JsonManager.DefaultEncoding.GetString(data), type, settings, withNodaTime);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="json">Json字符串</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<T> DeserializeAsync<T>(string json, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            string.IsNullOrWhiteSpace(json)
                ? default
                : await Task.Run(() => JsonConvert.DeserializeObject<T>(json, TouchSettings(settings, withNodaTime)));

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="json">Json字符串</param>
        /// <param name="type">反序列化对象类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<object> DeserializeAsync(string json, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            string.IsNullOrWhiteSpace(json)
                ? default
                : await Task.Run(() => JsonConvert.DeserializeObject(json, type, TouchSettings(settings, withNodaTime)));
    }
}

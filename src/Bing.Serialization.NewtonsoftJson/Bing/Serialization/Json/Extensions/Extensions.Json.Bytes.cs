using System;
using System.Threading.Tasks;
using Bing.Serialization.Json.Newtonsoft;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Bing.Serialization.Json
{
    /// <summary>
    /// Newtonsoft Json 扩展
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// 转换为Json字节数组
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static byte[] ToJsonBytes(this object obj, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.SerializeToBytes(obj, settings, withNodaTime);

        /// <summary>
        /// 转换为Json字节数组
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<byte[]> ToJsonBytesAsync(this object obj, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.SerializeToBytesAsync(obj, settings, withNodaTime);

        /// <summary>
        /// 从Json字节数组反序列化为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="data">Json字节数组</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static T FromJsonBytes<T>(this byte[] data, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.DeserializeFromBytes<T>(data, settings, withNodaTime);

        /// <summary>
        /// 从Json字节数组反序列化为对象
        /// </summary>
        /// <param name="data">Json字节数组</param>
        /// <param name="type">对象类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static object FromJsonBytes(this byte[] data, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.DeserializeFromBytes(data, type, settings, withNodaTime);

        /// <summary>
        /// 从Json字节数组反序列化为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="data">Json字节数组</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<T> FromJsonBytesAsync<T>(this byte[] data, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.DeserializeFromBytesAsync<T>(data, settings, withNodaTime);

        /// <summary>
        /// 从Json字节数组反序列化为对象
        /// </summary>
        /// <param name="data">Json字节数组</param>
        /// <param name="type">对象类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<object> FromJsonBytesAsync(this byte[] data, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.DeserializeFromBytesAsync(data, type, settings, withNodaTime);
    }
}

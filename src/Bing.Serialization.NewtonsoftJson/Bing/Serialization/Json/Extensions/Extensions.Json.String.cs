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
        /// 将Json字符串转换为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <param name="settings">序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static T FromJson<T>(this string json, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Deserialize<T>(json, settings, withNodaTime);

        /// <summary>
        /// 将Json字符串转换为对象
        /// </summary>
        /// <param name="json">json字符串</param>
        /// <param name="type">对象类型</param>
        /// <param name="settings">序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static object FromJson(this string json, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Deserialize(json, type, settings, withNodaTime);

        /// <summary>
        /// 将Json字符串转换为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <param name="settings">序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<T> FromJsonAsync<T>(this string json, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.DeserializeAsync<T>(json, settings, withNodaTime);

        /// <summary>
        /// 将Json字符串转换为对象
        /// </summary>
        /// <param name="json">json字符串</param>
        /// <param name="type">对象类型</param>
        /// <param name="settings">序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<object> FromJsonAsync(this string json, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.DeserializeAsync(json, type, settings, withNodaTime);
    }
}

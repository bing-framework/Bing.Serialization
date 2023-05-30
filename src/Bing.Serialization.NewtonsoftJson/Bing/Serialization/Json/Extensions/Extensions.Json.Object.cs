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
        /// 转换为Json字符串
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static string ToJson(this object obj, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Serialize(obj, settings, withNodaTime);

        /// <summary>
        /// 转换为Json字符串
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<string> ToJsonAsync(this object obj, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.SerializeAsync(obj, settings, withNodaTime);
    }
}

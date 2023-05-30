using System.Collections.Generic;
using Newtonsoft.Json.Linq;

// ReSharper disable once CheckNamespace
namespace Bing.Serialization.Json
{
    /// <summary>
    /// <see cref="JToken"/> 扩展
    /// </summary>
    public static partial class JTokenConversionExtensions
    {
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static JToken GetToken(this JToken token, string key) => token[key];

        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static string GetString(this JToken token, string key) => token[key].ToString();

        /// <summary>
        /// 获取布尔值
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static bool GetBool(this JToken token, string key) => token[key].ToObject<bool>();

        /// <summary>
        /// 获取32位整型
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static int GetInt(this JToken token, string key) => token[key].ToObject<int>();

        /// <summary>
        /// 获取64位浮点型
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static double GetDouble(this JToken token, string key) => token[key].ToObject<double>();

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static List<T> GetList<T>(this JToken token, string key) => token[key].ToObject<List<T>>();

        /// <summary>
        /// 获取字典
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static Dictionary<TKey, TValue> GetDictionary<TKey, TValue>(this JToken token, string key) => token[key].ToObject<Dictionary<TKey, TValue>>();

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="token">JToken</param>
        /// <param name="key">键名</param>
        public static T GetObject<T>(this JToken token, string key) => token[key].ToObject<T>();
    }
}

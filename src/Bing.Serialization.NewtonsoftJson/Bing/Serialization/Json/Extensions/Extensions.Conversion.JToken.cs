using System;
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
        /// 转换为32位整型
        /// </summary>
        /// <param name="token">JToken</param>
        public static int ToInt(this JToken token) => token?.ToObject<int>() ?? default;

        /// <summary>
        /// 转换为32位整型
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static int ToInt(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<int>() ?? default;

        /// <summary>
        /// 转换为64位整型
        /// </summary>
        /// <param name="token">JToken</param>
        public static long ToLong(this JToken token) => token?.ToObject<long>() ?? default;

        /// <summary>
        /// 转换为64位整型
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static long ToLong(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<long>() ?? default;

        /// <summary>
        /// 转换为32位浮点型
        /// </summary>
        /// <param name="token">JToken</param>
        public static float ToFloat(this JToken token) => token?.ToObject<float>() ?? default;

        /// <summary>
        /// 转换为32位浮点型
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static float ToFloat(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<float>() ?? default;

        /// <summary>
        /// 转换为64位浮点型
        /// </summary>
        /// <param name="token">JToken</param>
        public static double ToDouble(this JToken token) => token?.ToObject<double>() ?? default;

        /// <summary>
        /// 转换为64位浮点型
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static double ToDouble(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<double>() ?? default;

        /// <summary>
        /// 转换为列表
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="token">JToken</param>
        public static List<T> ToList<T>(this JToken token) => token?.ToObject<List<T>>();

        /// <summary>
        /// 转换为列表
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static List<T> ToList<T>(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<List<T>>();

        /// <summary>
        /// 转换为迭代集合
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="token">JToken</param>
        public static IEnumerable<T> ToEnumerable<T>(this JToken token) => token?.ToObject<IEnumerable<T>>();

        /// <summary>
        /// 转换为迭代集合
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static IEnumerable<T> ToEnumerable<T>(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<IEnumerable<T>>();

        /// <summary>
        /// 转换为字典
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="token">JToken</param>
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this JToken token) => token?.ToObject<Dictionary<TKey, TValue>>();

        /// <summary>
        /// 转换为字典
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<Dictionary<TKey, TValue>>();

        /// <summary>
        /// 转换为时间
        /// </summary>
        /// <param name="token">JToken</param>
        public static DateTime ToDateTime(this JToken token) => token?.ToObject<DateTime>() ?? default;

        /// <summary>
        /// 转换为时间
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static DateTime ToDateTime(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<DateTime>() ?? default;

        /// <summary>
        /// 转换为Guid
        /// </summary>
        /// <param name="token">JToken</param>
        public static Guid ToGuid(this JToken token) => token?.ToObject<Guid>() ?? default;

        /// <summary>
        /// 转换为Guid
        /// </summary>
        /// <param name="token">JToken</param>
        /// <param name="sectionName">部分名称</param>
        public static Guid ToGuid(this JToken token, string sectionName) =>
            token[sectionName]?.ToObject<Guid>() ?? default;
    }
}

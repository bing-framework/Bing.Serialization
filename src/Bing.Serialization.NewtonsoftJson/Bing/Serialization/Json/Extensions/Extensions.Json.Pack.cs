using System;
using System.IO;
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
        /// 装箱
        /// </summary>
        /// <param name="o">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static Stream JsonPack(this object o, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Pack(o, settings, withNodaTime);

        /// <summary>
        /// 装箱
        /// </summary>
        /// <param name="o">对象</param>
        /// <param name="stream">流</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static void JsonPackTo(this object o, Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Pack(o, stream, settings, withNodaTime);

        /// <summary>
        /// 装箱
        /// </summary>
        /// <param name="stream">流</param>
        /// <param name="obj">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static void JsonPackBy(this Stream stream, object obj, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Pack(obj, stream, settings, withNodaTime);

        /// <summary>
        /// 装箱
        /// </summary>
        /// <param name="o">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<Stream> JsonPackAsync(this object o, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.PackAsync(o, settings, withNodaTime);

        /// <summary>
        /// 装箱
        /// </summary>
        /// <param name="o">对象</param>
        /// <param name="stream">流</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task JsonPackToAsync(this object o, Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.PackAsync(o, stream, settings, withNodaTime);

        /// <summary>
        /// 装箱
        /// </summary>
        /// <param name="stream">流</param>
        /// <param name="obj">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task JsonPackByAsync(this Stream stream, object obj, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.PackAsync(obj, stream, settings, withNodaTime);

        /// <summary>
        /// 拆箱
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="stream">流</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static T JsonUnpack<T>(this Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Unpack<T>(stream, settings, withNodaTime);

        /// <summary>
        /// 拆箱
        /// </summary>
        /// <param name="stream">流</param>
        /// <param name="type">类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static object JsonUnpack(this Stream stream, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) => JsonHelper.Unpack(stream, type, settings, withNodaTime);

        /// <summary>
        /// 拆箱
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="stream">流</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<T> JsonUnpackAsync<T>(this Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.UnpackAsync<T>(stream, settings, withNodaTime);

        /// <summary>
        /// 拆箱
        /// </summary>
        /// <param name="stream">流</param>
        /// <param name="type">类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<object> JsonUnpackAsync(this Stream stream, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) => await JsonHelper.UnpackAsync(stream, type, settings, withNodaTime);
    }
}

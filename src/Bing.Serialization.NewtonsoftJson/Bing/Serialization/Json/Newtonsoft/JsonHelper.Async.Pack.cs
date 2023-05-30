using System;
using System.IO;
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
        /// 装箱
        /// </summary>
        /// <param name="o">对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<Stream> PackAsync(object o, JsonSerializerSettings settings = null, bool withNodaTime = false)
        {
            var ms = new MemoryStream();
            if (o is null)
                return ms;
            await PackAsync(o, ms, settings, withNodaTime);
            return ms;
        }

        /// <summary>
        /// 装箱
        /// </summary>
        /// <param name="o">对象</param>
        /// <param name="stream">流</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task PackAsync(object o, Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false)
        {
            if (o is null)
                return;
            var bytes = await SerializeToBytesAsync(o, settings, withNodaTime);
            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// 拆箱
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="stream">流</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<T> UnpackAsync<T>(Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            stream is null
                ? default
                : await DeserializeAsync<T>(JsonManager.DefaultEncoding.GetString(stream.CastToBytes()), settings, withNodaTime);

        /// <summary>
        /// 拆箱
        /// </summary>
        /// <param name="stream">流</param>
        /// <param name="type">类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static async Task<object> UnpackAsync(Stream stream, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            stream is null
                ? default
                : await DeserializeAsync(JsonManager.DefaultEncoding.GetString(stream.CastToBytes()), type, settings, withNodaTime);
    }
}

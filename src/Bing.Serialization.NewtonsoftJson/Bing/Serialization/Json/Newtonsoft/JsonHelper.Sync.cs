using System;
using Newtonsoft.Json;
using NodaTime;
using NodaTime.Serialization.JsonNet;

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
        public static byte[] SerializeToBytes(object o, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            o is null
                ? new byte[0]
                : JsonManager.DefaultEncoding.GetBytes(Serialize(o, settings, withNodaTime));

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="o">序列化对象</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static string Serialize(object o, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            o is null
                ? string.Empty
                : JsonConvert.SerializeObject(o, TouchSettings(settings, withNodaTime));

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="data">数据</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static T DeserializeFromBytes<T>(byte[] data, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            data is null || data.Length is 0
                ? default
                : Deserialize<T>(JsonManager.DefaultEncoding.GetString(data), settings, withNodaTime);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="type">类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static object DeserializeFromBytes(byte[] data, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            data is null || data.Length is 0
                ? default
                : Deserialize(JsonManager.DefaultEncoding.GetString(data), type, settings, withNodaTime);

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="json">Json字符串</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static T Deserialize<T>(string json, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            string.IsNullOrWhiteSpace(json)
                ? default
                : JsonConvert.DeserializeObject<T>(json, TouchSettings(settings, withNodaTime));

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="json">Json字符串</param>
        /// <param name="type">反序列化对象类型</param>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        public static object Deserialize(string json, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false) =>
            string.IsNullOrWhiteSpace(json)
                ? default
                : JsonConvert.DeserializeObject(json, type, TouchSettings(settings, withNodaTime));

        /// <summary>
        /// 触发设置
        /// </summary>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        private static JsonSerializerSettings TouchSettings(JsonSerializerSettings settings, bool withNodaTime)
        {
            if (settings == null)
                return withNodaTime ? JsonManager.DefaultSettingsWithNodaTime : JsonManager.DefaultSettings;
            UseNodaTimeIfNeed(settings, withNodaTime);
            return settings;
        }

        /// <summary>
        /// 启用基于 NodaTime 的 Json 序列化设置
        /// </summary>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="withNodaTime">是否启用NodaTime</param>
        private static void UseNodaTimeIfNeed(this JsonSerializerSettings settings, bool withNodaTime)
        {
            if (withNodaTime)
                settings.ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);
        }
    }
}

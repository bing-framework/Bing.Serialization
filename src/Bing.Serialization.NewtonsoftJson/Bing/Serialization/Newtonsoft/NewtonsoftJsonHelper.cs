using Newtonsoft.Json;
using NodaTime;
using System.Text;
using NodaTime.Serialization.JsonNet;

namespace Bing.Serialization.Newtonsoft;

/// <summary>
/// 基于Newtonsoft.Json实现的Json帮助类
/// </summary>
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Newtonsoft Json 管理器
    /// </summary>
    private static class Manager
    {
        /// <summary>
        /// 字符编码
        /// </summary>
        private static Encoding _encoding = Encoding.UTF8;

        /// <summary>
        /// Json序列化设置
        /// </summary>
        private static JsonSerializerSettings _settings = new();

        /// <summary>
        /// Json序列化设置 - 基于NodaTime
        /// </summary>
        private static JsonSerializerSettings _settingsWithNodaTime = new JsonSerializerSettings().ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);

        /// <summary>
        /// 默认字符编码
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }

        /// <summary>
        /// 默认Json序列化设置
        /// </summary>
        public static JsonSerializerSettings DefaultSettings
        {
            get => _settings;
            set => _settings = value ?? _settings;
        }

        /// <summary>
        /// 默认Json序列化设置 - 基于NodaTime
        /// </summary>
        public static JsonSerializerSettings DefaultSettingsWithNodaTime
        {
            get => _settingsWithNodaTime;
            set => _settingsWithNodaTime = value ?? _settingsWithNodaTime;
        }
    }

    /// <summary>
    /// 获取默认字符编码
    /// </summary>
    public static Encoding GetDefaultEncoding() => Manager.DefaultEncoding;

    /// <summary>
    /// 设置默认字符编码
    /// </summary>
    /// <param name="encoding">字符编码</param>
    public static void SetDefaultEncoding(Encoding encoding) => Manager.DefaultEncoding = encoding;

    /// <summary>
    /// 获取默认Json序列化设置
    /// </summary>
    public static JsonSerializerSettings GetDefaultSettings() => Manager.DefaultSettings;

    /// <summary>
    /// 设置默Json序列化设置
    /// </summary>
    /// <param name="settings">Json序列化设置</param>
    public static void SetDefaultSettings(JsonSerializerSettings settings) => Manager.DefaultSettings = settings;

    /// <summary>
    /// 获取默认Json序列化设置 - 基于NodaTime
    /// </summary>
    public static JsonSerializerSettings GetDefaultSettingsWithNodaTime => Manager.DefaultSettingsWithNodaTime;

    public static void SetDefaultSettingsWithNodaTime(JsonSerializerSettings settings)
    {
    }
}
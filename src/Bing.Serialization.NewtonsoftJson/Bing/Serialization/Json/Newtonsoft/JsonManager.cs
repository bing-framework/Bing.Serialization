using System.Text;
using Newtonsoft.Json;
using NodaTime;
using NodaTime.Serialization.JsonNet;

namespace Bing.Serialization.Json.Newtonsoft
{
    /// <summary>
    /// Json 管理器
    /// </summary>
    public static class JsonManager
    {
        /// <summary>
        /// 字符编码
        /// </summary>
        private static Encoding _encoding = Encoding.UTF8;

        /// <summary>
        /// Json序列化设置
        /// </summary>
        private static JsonSerializerSettings _settings = new JsonSerializerSettings();

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
}

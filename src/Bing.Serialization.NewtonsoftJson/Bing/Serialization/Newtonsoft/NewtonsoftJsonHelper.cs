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
    public static JsonSerializerSettings GetDefaultSettingsWithNodaTime() => Manager.DefaultSettingsWithNodaTime;

    /// <summary>
    /// 设置默认Json序列化设置 - 基于NodaTime
    /// </summary>
    /// <param name="settings">Json序列化设置</param>
    public static void SetDefaultSettingsWithNodaTime(JsonSerializerSettings settings) => Manager.DefaultSettingsWithNodaTime = settings;

    /// <summary>
    /// 转换Json序列化设置
    /// </summary>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    private static JsonSerializerSettings ToSettings(this JsonSerializerSettings settings, bool enableNodaTime)
    {
        if (settings is null)
            return enableNodaTime ? Manager.DefaultSettingsWithNodaTime : Manager.DefaultSettings;
        if (enableNodaTime)
            settings.ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);
        return settings;
    }

    /// <summary>
    /// 获取字符编码
    /// </summary>
    /// <param name="encoding">字符编码</param>
    private static Encoding GetEncoding(this Encoding encoding) => encoding ?? Manager.DefaultEncoding;

    /// <summary>
    /// 转换为字节数组
    /// </summary>
    /// <param name="stream">流</param>
    internal static byte[] CastToBytes(this Stream stream)
    {
        var bytes = new byte[stream.Length];
        if (stream.CanSeek && stream.Position > 0)
            stream.Seek(0, SeekOrigin.Begin);
        _ = stream.Read(bytes, 0, bytes.Length);
        if (stream.CanSeek)
            stream.Seek(0, SeekOrigin.Begin);
        return bytes;
    }

    /// <summary>
    /// 转换为字节数组
    /// </summary>
    /// <param name="stream">流</param>
    internal static async Task<byte[]> CastToBytesAsync(this Stream stream)
    {
        var bytes = new byte[stream.Length];
        if (stream.Position > 0 && stream.CanSeek)
            stream.Seek(0, SeekOrigin.Begin);
        _ = await stream.ReadAsync(bytes, 0, bytes.Length);
        if (stream.CanSeek)
            stream.Seek(0, SeekOrigin.Begin);
        return bytes;
    }
}
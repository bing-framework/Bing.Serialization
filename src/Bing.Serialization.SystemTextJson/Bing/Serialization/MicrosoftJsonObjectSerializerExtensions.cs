using Bing.Extensions;

namespace Bing.Serialization;

/// <summary>
/// System.Text.Json (MicrosoftJson) 序列化器扩展
/// </summary>
public static class MicrosoftJsonObjectSerializerExtensions
{
    /// <summary>
    /// 应用 <see cref="MicrosoftJsonObjectSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new MicrosoftJsonObjectSerializer());
    }

    /// <summary>
    /// 应用 <see cref="MicrosoftJsonObjectSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    /// <param name="options">Json序列化设置</param>
    public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry, JsonSerializerOptions options)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new MicrosoftJsonObjectSerializer(options));
    }

    /// <summary>
    /// 应用 <see cref="MicrosoftJsonObjectSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    /// <param name="optionsFactory">Json序列化设置工厂</param>
    public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry, Func<JsonSerializerOptions> optionsFactory)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new MicrosoftJsonObjectSerializer(optionsFactory));
    }

    /// <summary>
    /// 应用 <see cref="MicrosoftJsonObjectSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    /// <param name="serializerFactory">Json序列化器工厂</param>
    public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry, Func<MicrosoftJsonObjectSerializer> serializerFactory)
    {
        entry.CheckNull(nameof(entry));
        serializerFactory.CheckNull(nameof(serializerFactory));
        entry.ConfigureJsonSerializer(serializerFactory);
    }
}
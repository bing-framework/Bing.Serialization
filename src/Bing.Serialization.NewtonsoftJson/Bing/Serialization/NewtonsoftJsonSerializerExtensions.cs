using System.Text;
using Bing.Extensions;

namespace Bing.Serialization;

/// <summary>
/// Newtonsoft Json 序列化器扩展
/// </summary>
public static class NewtonsoftJsonSerializerExtensions
{
    /// <summary>
    /// 应用 <see cref="NewtonsoftJsonSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new NewtonsoftJsonSerializer());
    }

    /// <summary>
    /// 应用 <see cref="NewtonsoftJsonSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    /// <param name="options">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry, JsonSerializerSettings options, bool enableNodaTime = false, Encoding encoding = null)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new NewtonsoftJsonSerializer(options, enableNodaTime, encoding));
    }

    /// <summary>
    /// 应用 <see cref="NewtonsoftJsonSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    /// <param name="optionsFactory">Json序列化设置工厂</param>
    /// <param name="enableNodaTimeFactory">启用NodaTime工厂</param>
    /// <param name="encodingFactory">字符编码工厂</param>
    public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry, Func<JsonSerializerSettings> optionsFactory, Func<bool> enableNodaTimeFactory, Func<Encoding> encodingFactory)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new NewtonsoftJsonSerializer(optionsFactory, enableNodaTimeFactory, encodingFactory));
    }

    /// <summary>
    /// 应用 <see cref="NewtonsoftJsonSerializer"/>
    /// </summary>
    /// <param name="entry">Json序列化器配置入口</param>
    /// <param name="serializerFactory">Json序列化器工厂</param>
    public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry, Func<NewtonsoftJsonSerializer> serializerFactory)
    {
        entry.CheckNull(nameof(entry));
        serializerFactory.CheckNull(nameof(serializerFactory));
        entry.ConfigureJsonSerializer(serializerFactory);
    }
}
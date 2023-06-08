using Bing.IO;

namespace Bing.Serialization.SystemTextJson;

// 装箱
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// 装箱
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    public static void Pack<TValue>(TValue value, Stream stream, JsonSerializerOptions options = null)
    {
        if (value is null || stream is null)
            return;
        JsonSerializer.Serialize(stream, value, options);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// 装箱
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    public static void Pack(Type type, object value, Stream stream, JsonSerializerOptions options = null)
    {
        if (value is null || stream is null)
            return;
        JsonSerializer.Serialize(stream, value, type, options);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// 装箱
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await JsonSerializer.SerializeAsync(stream, value, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// 装箱
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task PackAsync(Type type, object value, Stream stream, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await JsonSerializer.SerializeAsync(stream, value, type, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}
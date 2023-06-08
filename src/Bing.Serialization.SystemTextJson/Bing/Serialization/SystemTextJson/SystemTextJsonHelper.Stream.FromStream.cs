using Bing.IO;

namespace Bing.Serialization.SystemTextJson;

// Stream -> Object
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// 从 <see cref="Stream"/> 转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    public static TValue FromStream<TValue>(Stream stream, JsonSerializerOptions options = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = JsonSerializer.Deserialize<TValue>(stream, options);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// 从 <see cref="Stream"/> 转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    public static object FromStream(Type type, Stream stream, JsonSerializerOptions options = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = JsonSerializer.Deserialize(stream, type, options);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// 从 <see cref="Stream"/> 转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await JsonSerializer.DeserializeAsync<TValue>(stream, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// 从 <see cref="Stream"/> 转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="stream">流</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await JsonSerializer.DeserializeAsync(stream, type, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }
}
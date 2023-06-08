namespace Bing.Serialization.SystemTextJson;

// Object -> Byte[]
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// 将对象转换为字节数组
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    public static byte[] ToBytes<TValue>(TValue value, JsonSerializerOptions options = null)
    {
        return value is null
            ? Array.Empty<byte>()
            : JsonSerializer.SerializeToUtf8Bytes(value, options);
    }

    /// <summary>
    /// 将对象转换为字节数组
    /// </summary>
    /// <param name="type">类型</param>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    public static byte[] ToBytes(Type type, object value, JsonSerializerOptions options = null)
    {
        return value is null
            ? Array.Empty<byte>()
            : JsonSerializer.SerializeToUtf8Bytes(value, type, options);
    }

    /// <summary>
    /// 将对象转换为字节数组
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Array.Empty<byte>()
            : await Task.Run(() => JsonSerializer.SerializeToUtf8Bytes(value, options), cancellationToken);
    }

    /// <summary>
    /// 将对象转换为字节数组
    /// </summary>
    /// <param name="type">类型</param>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Array.Empty<byte>()
            : await Task.Run(() => JsonSerializer.SerializeToUtf8Bytes(value, type, options), cancellationToken);
    }
}
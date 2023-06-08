namespace Bing.Serialization.SystemTextJson;

// Byte[] -> Object
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// 从字节数组转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="bytes">字节数组</param>
    /// <param name="options">Json序列化选项设置</param>
    public static TValue FromBytes<TValue>(byte[] bytes, JsonSerializerOptions options = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize<TValue>(bytes, options);
    }

    /// <summary>
    /// 从字节数组转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="bytes">字节数组</param>
    /// <param name="options">Json序列化选项设置</param>
    public static object FromBytes(Type type, byte[] bytes, JsonSerializerOptions options = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize(bytes, type, options);
    }

    /// <summary>
    /// 从字节数组转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="bytes">字节数组</param>
    /// <param name="options">Json序列化选项设置</param>
    public static TValue FromBytes<TValue>(ReadOnlySpan<byte> bytes, JsonSerializerOptions options = null)
    {
        return bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize<TValue>(bytes, options);
    }

    /// <summary>
    /// 从字节数组转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="bytes">字节数组</param>
    /// <param name="options">Json序列化选项设置</param>
    public static object FromBytes(Type type, ReadOnlySpan<byte> bytes, JsonSerializerOptions options = null)
    {
        return bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize(bytes, type, options);
    }

    /// <summary>
    /// 从字节数组转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="bytes">字节数组</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize<TValue>(bytes, options), cancellationToken);
    }

    /// <summary>
    /// 从字节数组转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="bytes">字节数组</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize(bytes, type, options), cancellationToken);
    }
}
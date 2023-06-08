namespace Bing.Serialization.SystemTextJson;

// Object -> Stream
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// 将对象转换成 <see cref="MemoryStream"/>
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    public static MemoryStream ToStream<TValue>(TValue value, JsonSerializerOptions options = null)
    {
        var ms = new MemoryStream();
        Pack(value, ms, options);
        return ms;
    }

    /// <summary>
    /// 将对象转换成 <see cref="MemoryStream"/>
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    public static MemoryStream ToStream(Type type, object value, JsonSerializerOptions options = null)
    {
        var ms = new MemoryStream();
        Pack(type, value, ms, options);
        return ms;
    }

    /// <summary>
    /// 将对象转换成 <see cref="MemoryStream"/>
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<MemoryStream> ToStreamAsync<TValue>(TValue value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        var ms = new MemoryStream();
        await PackAsync(value, ms, options, cancellationToken);
        return ms;
    }

    /// <summary>
    /// 将对象转换成 <see cref="MemoryStream"/>
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<MemoryStream> ToStreamAsync(Type type, object value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        var ms = new MemoryStream();
        await PackAsync(type, value, ms, options, cancellationToken);
        return ms;
    }
}
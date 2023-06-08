namespace Bing.Serialization.SystemTextJson;

// Object -> Json
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// 将对象转换为Json字符串
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    public static string ToJson<TValue>(TValue value, JsonSerializerOptions options = null) =>
        value is null
            ? string.Empty
            : JsonSerializer.Serialize(value, options.ToOptions());

    /// <summary>
    /// 将对象转换为Json字符串
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    public static string ToJson(Type type, object value, JsonSerializerOptions options = null) =>
        value is null
            ? string.Empty
            : JsonSerializer.Serialize(value, type, options.ToOptions());

    /// <summary>
    /// 将对象转换为Json字符串
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default) =>
        value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.Serialize(value, options.ToOptions()), cancellationToken);

    /// <summary>
    /// 将对象转换为Json字符串
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="value">值</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync(Type type, object value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default) =>
        value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.Serialize(value, type, options.ToOptions()), cancellationToken);
}
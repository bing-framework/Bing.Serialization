namespace Bing.Serialization.SystemTextJson;

// Json -> Object
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// 从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="options">Json序列化选项设置</param>
    public static TValue FromJson<TValue>(string json, JsonSerializerOptions options = null) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.Deserialize<TValue>(json, options.ToOptions());

    /// <summary>
    /// 从Json字符串转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="json">Json字符串</param>
    /// <param name="options">Json序列化选项设置</param>
    public static object FromJson(Type type, string json, JsonSerializerOptions options = null) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.Deserialize(json, type, options.ToOptions());

    /// <summary>
    /// 从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, JsonSerializerOptions options = null, CancellationToken cancellationToken = default) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize<TValue>(json, options.ToOptions()), cancellationToken);

    /// <summary>
    /// 从Json字符串转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="json">Json字符串</param>
    /// <param name="options">Json序列化选项设置</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<object> FromJsonAsync(Type type, string json, JsonSerializerOptions options = null, CancellationToken cancellationToken = default) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize(json, type, options.ToOptions()), cancellationToken);
}
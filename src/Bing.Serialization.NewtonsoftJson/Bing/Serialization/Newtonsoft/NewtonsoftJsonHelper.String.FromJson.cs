namespace Bing.Serialization.Newtonsoft;

// Json -> Object
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static TValue FromJson<TValue>(string json, JsonSerializerSettings settings = null, bool enableNodaTime = false) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : JsonConvert.DeserializeObject<TValue>(json, settings.ToSettings(enableNodaTime));

    /// <summary>
    /// 从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">json字符串</param>
    /// <param name="targetObject">目标对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static TValue FromJson<TValue>(string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : JsonConvert.DeserializeAnonymousType(json, targetObject, settings.ToSettings(enableNodaTime));

    /// <summary>
    /// 从Json字符串转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static object FromJson(Type type, string json, JsonSerializerSettings settings = null, bool enableNodaTime = false) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : JsonConvert.DeserializeObject(json, type, settings.ToSettings(enableNodaTime));

    /// <summary>
    /// 从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonConvert.DeserializeObject<TValue>(json, settings.ToSettings(enableNodaTime)), cancellationToken);

    /// <summary>
    /// 从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="targetObject">目标对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonConvert.DeserializeAnonymousType(json, targetObject, settings.ToSettings(enableNodaTime)), cancellationToken);

    /// <summary>
    /// 从Json字符串转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<object> FromJsonAsync(Type type, string json, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) =>
        string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonConvert.DeserializeObject(json, type, settings.ToSettings(enableNodaTime)), cancellationToken);
}
namespace Bing.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// 【Newtonsoft.Json】从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static TValue FromNewtonsoftJson<TValue>(this string json, JsonSerializerSettings settings = null, bool enableNodaTime = false) => 
        NewtonsoftJsonHelper.FromJson<TValue>(json, settings, enableNodaTime);

    /// <summary>
    /// 【Newtonsoft.Json】从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">json字符串</param>
    /// <param name="targetObject">目标对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static TValue FromNewtonsoftJson<TValue>(this string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false) => 
        NewtonsoftJsonHelper.FromJson(json, targetObject, settings, enableNodaTime);

    /// <summary>
    /// 【Newtonsoft.Json】从Json字符串转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static object FromNewtonsoftJson(this string json, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false) => 
        NewtonsoftJsonHelper.FromJson(type, json, settings, enableNodaTime);

    /// <summary>
    /// 【Newtonsoft.Json】从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<TValue> FromNewtonsoftJsonAsync<TValue>(this string json, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.FromJsonAsync<TValue>(json, settings, enableNodaTime, cancellationToken);

    /// <summary>
    /// 【Newtonsoft.Json】从Json字符串转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="json">Json字符串</param>
    /// <param name="targetObject">目标对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<TValue> FromNewtonsoftJsonAsync<TValue>(this string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.FromJsonAsync(json, targetObject, settings, enableNodaTime, cancellationToken);

    /// <summary>
    /// 【Newtonsoft.Json】从Json字符串转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="json">Json字符串</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<object> FromNewtonsoftJsonAsync(this string json, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.FromJsonAsync(type, json, settings, enableNodaTime, cancellationToken);
}
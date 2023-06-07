namespace Bing.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// 【Newtonsoft.Json】将对象转换为Json字符串
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static string ToNewtonsoftJson(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false) => 
        NewtonsoftJsonHelper.ToJson(value, settings, enableNodaTime);

    /// <summary>
    /// 【Newtonsoft.Json】将对象转换为Json字符串
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<string> ToNewtonsoftJsonAsync(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.ToJsonAsync(value, settings, enableNodaTime, cancellationToken);
}
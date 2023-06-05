namespace Bing.Serialization.Newtonsoft;

// Object -> Json
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 将对象转换为Json字符串
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    public static string ToJson(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false) =>
        value is null
            ? string.Empty
            : JsonConvert.SerializeObject(value, settings.ToSettings(enableNodaTime));

    /// <summary>
    /// 将对象转换为Json字符串
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default) =>
        value is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeObject(value, settings.ToSettings(enableNodaTime)), cancellationToken);
}
using System.Xml.Linq;

namespace Bing.Serialization.Newtonsoft;

// Json -> XObject
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 将Json字符串转换为 <see cref="XObject"/> 对象
    /// </summary>
    /// <param name="json">Json字符串</param>
    public static XObject ToXNode(string json) =>
        json is null
            ? default
            : JsonConvert.DeserializeXNode(json);

    /// <summary>
    /// 将Json字符串转换为 <see cref="XObject"/> 对象
    /// </summary>
    /// <param name="json">Json字符串</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<XObject> ToXNodeAsync(string json, CancellationToken cancellationToken = default) =>
        json is null
            ? default
            : await Task.Run(() => JsonConvert.DeserializeXNode(json), cancellationToken);
}
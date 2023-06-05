using System.Xml;

namespace Bing.Serialization.Newtonsoft;

// Json -> XmlNode
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 将Json字符串转换为 <see cref="XmlNode"/> 对象
    /// </summary>
    /// <param name="json">Json字符串</param>
    public static XmlNode ToJsXmlNode(string json) =>
        json is null
            ? default
            : JsonConvert.DeserializeXmlNode(json);

    /// <summary>
    /// 将Json字符串转换为 <see cref="XmlNode"/> 对象
    /// </summary>
    /// <param name="json">Json字符串</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<XmlNode> ToJsXmlNodeAsync(string json, CancellationToken cancellationToken = default) =>
        json is null
            ? default
            : await Task.Run(() => JsonConvert.DeserializeXmlNode(json), cancellationToken);
}
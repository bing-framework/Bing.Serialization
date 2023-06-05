using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Bing.Serialization.Newtonsoft;

// XmlNode -> Json
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 将 <see cref="XmlNode"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    public static string ToJson(XmlNode node) =>
        node is null
            ? string.Empty
            : JsonConvert.SerializeXmlNode(node);

    /// <summary>
    /// 将 <see cref="XmlNode"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    public static string ToJson(XmlNode node, Formatting formatting) =>
        node is null
            ? string.Empty
            : JsonConvert.SerializeXmlNode(node, formatting);

    /// <summary>
    /// 将 <see cref="XmlNode"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    /// <param name="omitRootObject">是否省略根对象</param>
    public static string ToJson(XmlNode node, Formatting formatting, bool omitRootObject) =>
        node is null
            ? string.Empty
            : JsonConvert.SerializeXmlNode(node, formatting, omitRootObject);

    /// <summary>
    /// 将 <see cref="XmlNode"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync(XmlNode node, CancellationToken cancellationToken = default) =>
        node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXmlNode(node), cancellationToken);

    /// <summary>
    /// 将 <see cref="XmlNode"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync(XmlNode node, Formatting formatting, CancellationToken cancellationToken = default) =>
        node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXmlNode(node, formatting), cancellationToken);

    /// <summary>
    /// 将 <see cref="XmlNode"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    /// <param name="omitRootObject">是否省略根对象</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync(XmlNode node, Formatting formatting, bool omitRootObject, CancellationToken cancellationToken = default) =>
        node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXmlNode(node, formatting, omitRootObject), cancellationToken);
}
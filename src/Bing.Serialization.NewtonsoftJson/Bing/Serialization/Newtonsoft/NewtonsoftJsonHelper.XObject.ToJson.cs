using System.Xml.Linq;

namespace Bing.Serialization.Newtonsoft;

// XObject -> Json
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 将 <see cref="XObject"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    public static string ToJson(XObject node) =>
        node is null
            ? string.Empty
            : JsonConvert.SerializeXNode(node);

    /// <summary>
    /// 将 <see cref="XObject"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    public static string ToJson(XObject node, Formatting formatting) =>
        node is null
            ? string.Empty
            : JsonConvert.SerializeXNode(node, formatting);

    /// <summary>
    /// 将 <see cref="XObject"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    /// <param name="omitRootObject">是否省略根对象</param>
    public static string ToJson(XObject node, Formatting formatting, bool omitRootObject) =>
        node is null
            ? string.Empty
            : JsonConvert.SerializeXNode(node, formatting, omitRootObject);


    /// <summary>
    /// 将 <see cref="XObject"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync(XObject node, CancellationToken cancellationToken = default) =>
        node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXNode(node), cancellationToken);

    /// <summary>
    /// 将 <see cref="XObject"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync(XObject node, Formatting formatting,
        CancellationToken cancellationToken = default) =>
        node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXNode(node, formatting), cancellationToken);

    /// <summary>
    /// 将 <see cref="XObject"/> 对象转换为Json字符串
    /// </summary>
    /// <param name="node">XML节点</param>
    /// <param name="formatting">Json格式化</param>
    /// <param name="omitRootObject">是否省略根对象</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<string> ToJsonAsync(XObject node, Formatting formatting, bool omitRootObject, CancellationToken cancellationToken = default) =>
        node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXNode(node, formatting, omitRootObject), cancellationToken);
}
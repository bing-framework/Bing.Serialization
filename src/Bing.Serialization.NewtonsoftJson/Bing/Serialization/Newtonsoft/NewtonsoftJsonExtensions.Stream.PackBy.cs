using System.Text;

namespace Bing.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// 【Newtonsoft.Json】装箱
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static void NewtonsoftPackBy(this Stream stream, object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) =>
        NewtonsoftJsonHelper.Pack(value, stream, settings, enableNodaTime, encoding);

    /// <summary>
    /// 【Newtonsoft.Json】装箱
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task NewtonsoftPackByAsync(this Stream stream, object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) =>
        NewtonsoftJsonHelper.PackAsync(value, stream, settings, enableNodaTime, encoding, cancellationToken);
}
using System.Text;
using Bing.Text;

namespace Bing.Serialization.Newtonsoft;

// Object -> Byte[]
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 将对象转换为字节数组
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static byte[] ToBytes(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) =>
        value is null
            ? Array.Empty<byte>()
            : ToJson(value, settings, enableNodaTime).ToBytes(encoding.GetEncoding());

    /// <summary>
    /// 将对象转换为字节数组
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<byte[]> ToBytesAsync(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) =>
        value is null
            ? Array.Empty<byte>()
            : (await ToJsonAsync(value, settings, enableNodaTime, cancellationToken)).ToBytes(encoding.GetEncoding());
}
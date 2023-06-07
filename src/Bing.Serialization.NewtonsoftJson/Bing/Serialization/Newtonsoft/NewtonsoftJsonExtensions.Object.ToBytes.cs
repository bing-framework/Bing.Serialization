using System.Text;

namespace Bing.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// 【Newtonsoft.Json】将对象转换为字节数组
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static byte[] ToNewtonsoftBytes(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) => 
        NewtonsoftJsonHelper.ToBytes(value, settings, enableNodaTime, encoding);

    /// <summary>
    /// 【Newtonsoft.Json】将对象转换为字节数组
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<byte[]> ToNewtonsoftBytesAsync(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.ToBytesAsync(value, settings, enableNodaTime, encoding, cancellationToken);
}
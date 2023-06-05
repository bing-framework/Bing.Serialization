using System.Text;

namespace Bing.Serialization.Newtonsoft;

// Object -> Stream
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 将对象转换成 <see cref="Stream"/>
    /// </summary>
    /// <param name="value">对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static MemoryStream ToStream(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        var stream = new MemoryStream();
        Pack(value, stream, settings, enableNodaTime, encoding);
        return stream;
    }

    /// <summary>
    /// 将对象转换成 <see cref="Stream"/>
    /// </summary>
    /// <param name="value">对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<MemoryStream> ToStreamAsync(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, settings, enableNodaTime, encoding, cancellationToken);
        return stream;
    }
}
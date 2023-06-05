using System.Text;
using Bing.IO;

namespace Bing.Serialization.Newtonsoft;

// 装箱
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 装箱
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static void Pack(object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        if (value is null || stream is null)
            return;
        var bytes = ToBytes(value, settings, enableNodaTime, encoding);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// 装箱
    /// </summary>
    /// <param name="value">值</param>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task PackAsync(object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var bytes = await ToBytesAsync(value, settings, enableNodaTime, encoding, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}
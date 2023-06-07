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
    public static void NewtonsoftPackTo(this object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) => 
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
    public static Task NewtonsoftPackToAsync(this object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.PackAsync(value, stream, settings, enableNodaTime, encoding, cancellationToken);
    }
}
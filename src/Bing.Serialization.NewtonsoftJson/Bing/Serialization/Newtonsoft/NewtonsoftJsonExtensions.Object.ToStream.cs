using System.Text;

namespace Bing.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// 【Newtonsoft.Json】将对象转换成 <see cref="MemoryStream"/>
    /// </summary>
    /// <param name="value">对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static MemoryStream ToNewtonsoftStream(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) => 
        NewtonsoftJsonHelper.ToStream(value, settings, enableNodaTime, encoding);

    /// <summary>
    /// 【Newtonsoft.Json】将对象转换成 <see cref="MemoryStream"/>
    /// </summary>
    /// <param name="value">对象</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<MemoryStream> ToNewtonsoftStreamAsync(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.ToStreamAsync(value, settings, enableNodaTime, encoding, cancellationToken);
}
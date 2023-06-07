using System.Text;

namespace Bing.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// 【Newtonsoft.Json】从 <see cref="Stream"/> 转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static TValue FromNewtonsoftStream<TValue>(this Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) => 
        NewtonsoftJsonHelper.FromStream<TValue>(stream, settings, enableNodaTime, encoding);

    /// <summary>
    /// 【Newtonsoft.Json】从 <see cref="Stream"/> 转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static object FromNewtonsoftStream(this Stream stream, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) => 
        NewtonsoftJsonHelper.FromStream(type, stream, settings, enableNodaTime, encoding);

    /// <summary>
    /// 【Newtonsoft.Json】从 <see cref="Stream"/> 转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<TValue> FromNewtonsoftStreamAsync<TValue>(this Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.FromStreamAsync<TValue>(stream, settings, enableNodaTime, encoding, cancellationToken);

    /// <summary>
    /// 【Newtonsoft.Json】从 <see cref="Stream"/> 转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="stream">流</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<object> FromNewtonsoftStreamAsync(this Stream stream, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.FromStreamAsync(type, stream, settings, enableNodaTime, encoding, cancellationToken);
}
using System.Text;

namespace Bing.Serialization.Newtonsoft;

/// <summary>
/// Newtonsoft.Json 扩展
/// </summary>
public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// 【Newtonsoft.Json】从字节数组转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static TValue FromNewtonsoftJsonBytes<TValue>(this byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) => 
        NewtonsoftJsonHelper.FromBytes<TValue>(bytes, settings, enableNodaTime, encoding);

    /// <summary>
    /// 【Newtonsoft.Json】从字节数组转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static object FromNewtonsoftJsonBytes(this byte[] bytes, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null) => 
        NewtonsoftJsonHelper.FromBytes(type, bytes, settings, enableNodaTime, encoding);

    /// <summary>
    /// 【Newtonsoft.Json】从字节数组转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<TValue> FromNewtonsoftJsonBytesAsync<TValue>(this byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.FromBytesAsync<TValue>(bytes, settings, enableNodaTime, encoding, cancellationToken);

    /// <summary>
    /// 【Newtonsoft.Json】从字节数组转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static Task<object> FromNewtonsoftJsonBytesAsync(this byte[] bytes, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default) => 
        NewtonsoftJsonHelper.FromBytesAsync(type, bytes, settings, enableNodaTime, encoding, cancellationToken);
}
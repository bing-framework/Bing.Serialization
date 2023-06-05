using System.Text;
using Bing.Text;

namespace Bing.Serialization.Newtonsoft;

// Byte[] -> Object
public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// 从字节数组转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static TValue FromBytes<TValue>(byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson<TValue>(bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime);
    }

    /// <summary>
    /// 从字节数组转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    public static object FromBytes(Type type, byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson(type, bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime);
    }

    /// <summary>
    /// 从字节数组转换成指定 <typeparamref name="TValue"/> 类型的对象
    /// </summary>
    /// <typeparam name="TValue">对象类型</typeparam>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync<TValue>(bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime, cancellationToken);
    }

    /// <summary>
    /// 从字节数组转换成指定类型的对象
    /// </summary>
    /// <param name="type">对象类型</param>
    /// <param name="bytes">字节数组</param>
    /// <param name="settings">Json序列化设置</param>
    /// <param name="enableNodaTime">启用NodaTime</param>
    /// <param name="encoding">字符编码</param>
    /// <param name="cancellationToken">取消令牌</param>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync(type, bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime, cancellationToken);
    }
}
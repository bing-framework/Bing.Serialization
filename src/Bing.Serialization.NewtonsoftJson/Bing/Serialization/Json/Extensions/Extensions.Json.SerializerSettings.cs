using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Bing.Serialization.Json
{
    /// <summary>
    /// Newtonsoft Json 扩展
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// 转换为Json序列化器
        /// </summary>
        /// <param name="jsonSerializerSettings">Json序列化设置</param>
        public static JsonSerializer ToSerializer(this JsonSerializerSettings jsonSerializerSettings)
        {
            if (jsonSerializerSettings == null)
                throw new ArgumentNullException(nameof(jsonSerializerSettings));
            return JsonSerializer.Create(jsonSerializerSettings);
        }

        /// <summary>
        /// 序列化到内存流
        /// </summary>
        /// <typeparam name="TRequest">请求对象类型</typeparam>
        /// <param name="jsonSerializerSettings">Json序列化器设置</param>
        /// <param name="request">请求对象</param>
        /// <param name="cancellationToken">取消令牌</param>
        public static Task<MemoryStream> SerializeToMemoryStreamAsync<TRequest>(
            this JsonSerializerSettings jsonSerializerSettings, TRequest request,
            CancellationToken cancellationToken) => jsonSerializerSettings.ToSerializer()
            .SerializeToMemoryStreamAsync(request, cancellationToken);

        /// <summary>
        /// 序列化为字符串
        /// </summary>
        /// <typeparam name="TRequest">请求对象类型</typeparam>
        /// <param name="jsonSerializerSettings">Json序列化器设置</param>
        /// <param name="request">请求对象</param>
        public static string SerializeToString<TRequest>(this JsonSerializerSettings jsonSerializerSettings,
            TRequest request) => jsonSerializerSettings.ToSerializer().SerializeToString(request);

        /// <summary>
        /// 反序列化为对象
        /// </summary>
        /// <typeparam name="TResponse">响应对象类型</typeparam>
        /// <param name="jsonSerializerSettings">Json序列化器设置</param>
        /// <param name="json">Json字符串</param>
        public static TResponse DeserializeFromString<TResponse>(this JsonSerializerSettings jsonSerializerSettings,
            string json) => jsonSerializerSettings.ToSerializer().DeserializeFromString<TResponse>(json);
    }
}

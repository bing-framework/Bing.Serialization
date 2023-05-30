using System;
using System.Globalization;
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
        /// 序列化为字符串
        /// </summary>
        /// <typeparam name="TRequest">请求对象类型</typeparam>
        /// <param name="serializer">Json序列化器</param>
        /// <param name="request">请求对象</param>
        public static string SerializeToString<TRequest>(this JsonSerializer serializer, TRequest request)
        {
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            using (var stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                using (var jsonWriter = new JsonTextWriter(stringWriter))
                {
                    serializer.Serialize(jsonWriter, request);
                    jsonWriter.Flush();
                    return stringWriter.ToString();
                }
            }
        }

        /// <summary>
        /// 反序列化为对象
        /// </summary>
        /// <typeparam name="TResponse">响应对象类型</typeparam>
        /// <param name="serializer">Json序列化器</param>
        /// <param name="json">Json字符串</param>
        public static TResponse DeserializeFromString<TResponse>(this JsonSerializer serializer, string json)
        {
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentNullException(nameof(json));
            using (var stringReader = new StringReader(json))
            {
                using (var jsonReader = new JsonTextReader(stringReader))
                {
                    return serializer.Deserialize<TResponse>(jsonReader);
                }
            }
        }

        /// <summary>
        /// 序列化到内存流
        /// </summary>
        /// <typeparam name="TRequest">请求对象类型</typeparam>
        /// <param name="serializer">Json序列化器</param>
        /// <param name="request">请求对象</param>
        /// <param name="cancellationToken">取消令牌</param>
        public static async Task<MemoryStream> SerializeToMemoryStreamAsync<TRequest>(this JsonSerializer serializer,
            TRequest request, CancellationToken cancellationToken)
        {
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            using (var stream = new MemoryStream())
            {
                using (TextWriter textWriter = new StreamWriter(stream))
                {
                    using (var jsonWriter = new JsonTextWriter(textWriter))
                    {
                        serializer.Serialize(jsonWriter, request);
                        await jsonWriter.FlushAsync(cancellationToken).ConfigureAwait(false);
                        await textWriter.FlushAsync().ConfigureAwait(false);
                        stream.Position = 0;
                        if (!stream.TryGetBuffer(out var buffer))
                            throw new InvalidOperationException($"调用 {nameof(stream.TryGetBuffer)} 返回false.");
                        return new MemoryStream(buffer.Array, buffer.Offset, buffer.Count);
                    }
                }
            }
        }
    }
}

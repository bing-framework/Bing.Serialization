using System.Text;
using Bing.Serialization.Newtonsoft;

namespace Bing.Serialization
{
    /// <summary>
    /// Newtonsoft Json 序列化器
    /// </summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        /// <summary>
        /// Json序列化设置
        /// </summary>
        private readonly JsonSerializerSettings _settings;

        /// <summary>
        /// 启用NodaTime
        /// </summary>
        private readonly bool _enableNodaTime;

        /// <summary>
        /// 字符编码
        /// </summary>
        private readonly Encoding _encoding;

        /// <summary>
        /// 初始化一个<see cref="NewtonsoftJsonHelper"/>类型的实例
        /// </summary>
        public NewtonsoftJsonSerializer()
        {
            _settings = NewtonsoftJsonHelper.GetDefaultSettings();
            _enableNodaTime = false;
            _encoding = NewtonsoftJsonHelper.GetDefaultEncoding();
        }

        /// <summary>
        /// 初始化一个<see cref="NewtonsoftJsonHelper"/>类型的实例
        /// </summary>
        /// <param name="settings">Json序列化设置</param>
        /// <param name="enableNodaTime">启用NodaTime</param>
        /// <param name="encoding">字符编码</param>
        public NewtonsoftJsonSerializer(JsonSerializerSettings settings, bool enableNodaTime = false, Encoding encoding = null)
        {
            _settings = settings ?? NewtonsoftJsonHelper.GetDefaultSettings();
            _enableNodaTime = enableNodaTime;
            _encoding = encoding ?? NewtonsoftJsonHelper.GetDefaultEncoding();
        }

        /// <summary>
        /// 初始化一个<see cref="NewtonsoftJsonHelper"/>类型的实例
        /// </summary>
        /// <param name="settingsFactory">Json序列化设置工厂</param>
        /// <param name="enableNodaTimeFactory">启用NodaTime工厂</param>
        /// <param name="encodingFactory">字符编码工厂</param>
        public NewtonsoftJsonSerializer(Func<JsonSerializerSettings> settingsFactory, Func<bool> enableNodaTimeFactory, Func<Encoding> encodingFactory)
        {
            _settings = settingsFactory is null ? NewtonsoftJsonHelper.GetDefaultSettings() : settingsFactory();
            _enableNodaTime = enableNodaTimeFactory?.Invoke() ?? false;
            _encoding = encodingFactory is null ? NewtonsoftJsonHelper.GetDefaultEncoding() : encodingFactory();
        }

        /// <inheritdoc />
        public string Serialize<TValue>(TValue value) => NewtonsoftJsonHelper.ToJson(value, _settings, _enableNodaTime);

        /// <inheritdoc />
        public TValue Deserialize<TValue>(string data) => NewtonsoftJsonHelper.FromJson<TValue>(data, _settings, _enableNodaTime);

        /// <inheritdoc />
        public object Deserialize(Type type, string data) => NewtonsoftJsonHelper.FromJson(type, data, _settings, _enableNodaTime);

        /// <inheritdoc />
        public Task<string> SerializeAsync<TValue>(TValue value) => NewtonsoftJsonHelper.ToJsonAsync(value, _settings, _enableNodaTime);

        /// <inheritdoc />
        public Task<TValue> DeserializeAsync<TValue>(string data) => NewtonsoftJsonHelper.FromJsonAsync<TValue>(data, _settings, _enableNodaTime);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(Type type, string data) => NewtonsoftJsonHelper.FromJsonAsync(type, data, _settings, _enableNodaTime);

        /// <inheritdoc />
        public byte[] ToBytes<TValue>(TValue value) => NewtonsoftJsonHelper.ToBytes(value, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public byte[] ToBytes(Type type, object value) => NewtonsoftJsonHelper.ToBytes(value, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public TValue FromBytes<TValue>(byte[] bytes) => NewtonsoftJsonHelper.FromBytes<TValue>(bytes, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public object FromBytes(Type type, byte[] bytes) => NewtonsoftJsonHelper.FromBytes(type, bytes, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public string ToText<TValue>(TValue value) => NewtonsoftJsonHelper.ToJson(value, _settings, _enableNodaTime);

        /// <inheritdoc />
        public string ToText(Type type, object value) => NewtonsoftJsonHelper.ToJson(value, _settings, _enableNodaTime);

        /// <inheritdoc />
        public TValue FromText<TValue>(string text) => NewtonsoftJsonHelper.FromJson<TValue>(text, _settings, _enableNodaTime);

        /// <inheritdoc />
        public object FromText(Type type, string text) => NewtonsoftJsonHelper.FromJson(type, text, _settings, _enableNodaTime);

        /// <inheritdoc />
        public void Pack<TValue>(TValue value, Stream stream) => NewtonsoftJsonHelper.Pack(value, stream, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public void Pack(Type type, object value, Stream stream) => NewtonsoftJsonHelper.Pack(value, stream, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public MemoryStream ToStream<TValue>(TValue value) => NewtonsoftJsonHelper.ToStream(value, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public MemoryStream ToStream(Type type, object value) => NewtonsoftJsonHelper.ToStream(value, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public TValue FromStream<TValue>(Stream stream) => NewtonsoftJsonHelper.FromStream<TValue>(stream, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public object FromStream(Type type, Stream stream) => NewtonsoftJsonHelper.FromStream(type, stream, _settings, _enableNodaTime, _encoding);

        /// <inheritdoc />
        public Task PackAsync<TValue>(TValue value, Stream stream, CancellationToken cancellationToken = default) =>
            NewtonsoftJsonHelper.PackAsync(value, stream, _settings, _enableNodaTime, _encoding, cancellationToken);

        /// <inheritdoc />
        public Task PackAsync(Type type, object value, Stream stream, CancellationToken cancellationToken = default) =>
            NewtonsoftJsonHelper.PackAsync(value, stream, _settings, _enableNodaTime, _encoding, cancellationToken);

        /// <inheritdoc />
        public Task<MemoryStream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default) =>
            NewtonsoftJsonHelper.ToStreamAsync(value, _settings, _enableNodaTime, _encoding, cancellationToken);

        /// <inheritdoc />
        public Task<MemoryStream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default) =>
            NewtonsoftJsonHelper.ToStreamAsync(value, _settings, _enableNodaTime, _encoding, cancellationToken);

        /// <inheritdoc />
        public Task<TValue> FromStreamAsync<TValue>(Stream stream, CancellationToken cancellationToken = default) =>
            NewtonsoftJsonHelper.FromStreamAsync<TValue>(stream, _settings, _enableNodaTime, _encoding, cancellationToken);

        /// <inheritdoc />
        public Task<object> FromStreamAsync(Type type, Stream stream, CancellationToken cancellationToken = default) =>
            NewtonsoftJsonHelper.FromStreamAsync(type, stream, _settings, _enableNodaTime, _encoding, cancellationToken);
    }
}

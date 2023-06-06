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
        /// 初始化一个<see cref="NewtonsoftJsonHelper"/>类型的实例
        /// </summary>
        public NewtonsoftJsonSerializer()
        {
            _settings = NewtonsoftJsonHelper.GetDefaultSettings();
        }

        /// <summary>
        /// 初始化一个<see cref="NewtonsoftJsonHelper"/>类型的实例
        /// </summary>
        /// <param name="settings">Json序列化设置</param>
        public NewtonsoftJsonSerializer(JsonSerializerSettings settings)
        {
            _settings = settings ?? NewtonsoftJsonHelper.GetDefaultSettings();
        }

        /// <summary>
        /// 初始化一个<see cref="NewtonsoftJsonHelper"/>类型的实例
        /// </summary>
        /// <param name="settingsFactory">Json序列化设置工厂</param>
        public NewtonsoftJsonSerializer(Func<JsonSerializerSettings> settingsFactory)
        {
            _settings = settingsFactory is null ? NewtonsoftJsonHelper.GetDefaultSettings() : settingsFactory();
        }

        /// <inheritdoc />
        public string Serialize<TValue>(TValue value) => NewtonsoftJsonHelper.ToJson(value, _settings);

        /// <inheritdoc />
        public Task<string> SerializeAsync<TValue>(TValue value) => NewtonsoftJsonHelper.ToJsonAsync(value, _settings);

        /// <inheritdoc />
        public TValue Deserialize<TValue>(string data) => NewtonsoftJsonHelper.FromJson<TValue>(data, _settings);

        /// <inheritdoc />
        public object Deserialize(Type type, string data) => NewtonsoftJsonHelper.FromJson(type, data, _settings);

        /// <inheritdoc />
        public Task<TValue> DeserializeAsync<TValue>(string data) => NewtonsoftJsonHelper.FromJsonAsync<TValue>(data, _settings);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(Type type, string data) => NewtonsoftJsonHelper.FromJsonAsync(type, data, _settings);

        /// <inheritdoc />
        public byte[] ToBytes<TValue>(TValue value) => NewtonsoftJsonHelper.ToBytes(value, _settings);

        /// <inheritdoc />
        public byte[] ToBytes(Type type, object value) => NewtonsoftJsonHelper.ToBytes(value, _settings);

        /// <inheritdoc />
        public TValue FromBytes<TValue>(byte[] bytes) => NewtonsoftJsonHelper.FromBytes<TValue>(bytes, _settings);

        /// <inheritdoc />
        public object FromBytes(Type type, byte[] bytes) => NewtonsoftJsonHelper.FromBytes(type, bytes, _settings);

        /// <inheritdoc />
        public MemoryStream ToStream<TValue>(TValue value) => NewtonsoftJsonHelper.ToStream(value, _settings);

        /// <inheritdoc />
        public MemoryStream ToStream(Type type, object value) => NewtonsoftJsonHelper.ToStream(value, _settings);

        /// <inheritdoc />
        public TValue Stream<TValue>(Stream stream) => NewtonsoftJsonHelper.FromStream<TValue>(stream);

        /// <inheritdoc />
        public object FromStream(Type type, Stream stream) => NewtonsoftJsonHelper.FromStream(type, stream);

        /// <inheritdoc />
        public Task<MemoryStream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default) => NewtonsoftJsonHelper.ToStreamAsync(value, _settings, cancellationToken: cancellationToken);

        /// <inheritdoc />
        public Task<MemoryStream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default) => NewtonsoftJsonHelper.ToStreamAsync(value, _settings, cancellationToken: cancellationToken);

        /// <inheritdoc />
        public Task<TValue> FromStreamAsync<TValue>(Stream stream, CancellationToken cancellationToken = default) => NewtonsoftJsonHelper.FromStreamAsync<TValue>(stream, _settings, cancellationToken: cancellationToken);

        /// <inheritdoc />
        public Task<object> FromStreamAsync(Type type, Stream stream, CancellationToken cancellationToken = default) => NewtonsoftJsonHelper.FromStreamAsync(type, stream, _settings, cancellationToken: cancellationToken);

        /// <inheritdoc />
        public TValue FromText<TValue>(string text) => NewtonsoftJsonHelper.FromJson<TValue>(text, _settings);

        /// <inheritdoc />
        public object FromText(Type type, string text) => NewtonsoftJsonHelper.FromJson(type, text, _settings);

        /// <inheritdoc />
        public string ToText<TValue>(TValue value) => NewtonsoftJsonHelper.ToJson(value, _settings);

        /// <inheritdoc />
        public string ToText(Type type, object value) => NewtonsoftJsonHelper.ToJson(value, _settings);

        /// <inheritdoc />
        public TValue FromJson<TValue>(string json) => NewtonsoftJsonHelper.FromJson<TValue>(json, _settings);

        /// <inheritdoc />
        public object FromJson(Type type, string json) => NewtonsoftJsonHelper.FromJson(type, json, _settings);

        /// <inheritdoc />
        public string ToJson<TValue>(TValue value) => NewtonsoftJsonHelper.ToJson(value, _settings);

        /// <inheritdoc />
        public string ToJson(Type type, object value) => NewtonsoftJsonHelper.ToJson(value, _settings);
    }
}

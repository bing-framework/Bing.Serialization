using Bing.Serialization.SystemTextJson;

namespace Bing.Serialization;

/// <summary>
/// Microsoft System.Text.Json 序列化器
/// </summary>
public class MicrosoftJsonObjectSerializer : IJsonSerializer
{
    /// <summary>
    /// Json序列化选项设置
    /// </summary>
    private readonly JsonSerializerOptions _options;

    /// <summary>
    /// 初始化一个<see cref="MicrosoftJsonObjectSerializer"/>类型的实例
    /// </summary>
    public MicrosoftJsonObjectSerializer()
    {
        _options = SystemTextJsonHelper.GetDefaultOptions();
    }

    /// <summary>
    /// 初始化一个<see cref="MicrosoftJsonObjectSerializer"/>类型的实例
    /// </summary>
    /// <param name="options">Json序列化选项设置</param>
    public MicrosoftJsonObjectSerializer(JsonSerializerOptions options)
    {
        _options = options ?? SystemTextJsonHelper.GetDefaultOptions();
    }

    /// <summary>
    /// 初始化一个<see cref="MicrosoftJsonObjectSerializer"/>类型的实例
    /// </summary>
    /// <param name="optionsFactory">Json序列化选项设置工厂</param>
    public MicrosoftJsonObjectSerializer(Func<JsonSerializerOptions> optionsFactory)
    {
        _options = optionsFactory is null ? SystemTextJsonHelper.GetDefaultOptions() : optionsFactory();
    }

    /// <inheritdoc />
    public string Serialize<TValue>(TValue value) => SystemTextJsonHelper.ToJson(value, _options);

    /// <inheritdoc />
    public TValue Deserialize<TValue>(string data) => SystemTextJsonHelper.FromJson<TValue>(data, _options);

    /// <inheritdoc />
    public object Deserialize(Type type, string data) => SystemTextJsonHelper.FromJson(type, data, _options);

    /// <inheritdoc />
    public Task<string> SerializeAsync<TValue>(TValue value) => SystemTextJsonHelper.ToJsonAsync(value, _options);

    /// <inheritdoc />
    public Task<TValue> DeserializeAsync<TValue>(string data) => SystemTextJsonHelper.FromJsonAsync<TValue>(data, _options);

    /// <inheritdoc />
    public Task<object> DeserializeAsync(Type type, string data) => SystemTextJsonHelper.FromJsonAsync(type, data, _options);

    /// <inheritdoc />
    public byte[] ToBytes<TValue>(TValue value) => SystemTextJsonHelper.ToBytes(value, _options);

    /// <inheritdoc />
    public byte[] ToBytes(Type type, object value) => SystemTextJsonHelper.ToBytes(type, value, _options);

    /// <inheritdoc />
    public TValue FromBytes<TValue>(byte[] bytes) => SystemTextJsonHelper.FromBytes<TValue>(bytes, _options);

    /// <inheritdoc />
    public object FromBytes(Type type, byte[] bytes) => SystemTextJsonHelper.FromBytes(type, bytes, _options);

    /// <inheritdoc />
    public string ToText<TValue>(TValue value) => SystemTextJsonHelper.ToJson(value, _options);

    /// <inheritdoc />
    public string ToText(Type type, object value) => SystemTextJsonHelper.ToJson(type, value, _options);

    /// <inheritdoc />
    public TValue FromText<TValue>(string text) => SystemTextJsonHelper.FromJson<TValue>(text, _options);

    /// <inheritdoc />
    public object FromText(Type type, string text) => SystemTextJsonHelper.FromJson(type, text, _options);

    /// <inheritdoc />
    public void Pack<TValue>(TValue value, Stream stream) => SystemTextJsonHelper.Pack(value, stream, _options);

    /// <inheritdoc />
    public void Pack(Type type, object value, Stream stream) => SystemTextJsonHelper.Pack(type, value, stream, _options);

    /// <inheritdoc />
    public MemoryStream ToStream<TValue>(TValue value) => SystemTextJsonHelper.ToStream(value, _options);

    /// <inheritdoc />
    public MemoryStream ToStream(Type type, object value) => SystemTextJsonHelper.ToStream(type, value, _options);

    /// <inheritdoc />
    public TValue FromStream<TValue>(Stream stream) => SystemTextJsonHelper.FromStream<TValue>(stream);

    /// <inheritdoc />
    public object FromStream(Type type, Stream stream) => SystemTextJsonHelper.FromStream(type, stream, _options);

    /// <inheritdoc />
    public Task PackAsync<TValue>(TValue value, Stream stream, CancellationToken cancellationToken = default) => 
        SystemTextJsonHelper.PackAsync(value, stream, _options, cancellationToken);

    /// <inheritdoc />
    public Task PackAsync(Type type, object value, Stream stream, CancellationToken cancellationToken = default) => 
        SystemTextJsonHelper.PackAsync(type, value, stream, _options, cancellationToken);

    /// <inheritdoc />
    public Task<MemoryStream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default) => 
        SystemTextJsonHelper.ToStreamAsync(value, _options, cancellationToken);

    /// <inheritdoc />
    public Task<MemoryStream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default) => 
        SystemTextJsonHelper.ToStreamAsync(type, value, _options, cancellationToken);

    /// <inheritdoc />
    public Task<TValue> FromStreamAsync<TValue>(Stream stream, CancellationToken cancellationToken = default) => 
        SystemTextJsonHelper.FromStreamAsync<TValue>(stream, _options, cancellationToken);

    /// <inheritdoc />
    public Task<object> FromStreamAsync(Type type, Stream stream, CancellationToken cancellationToken = default) => 
        SystemTextJsonHelper.FromStreamAsync(type, stream, _options, cancellationToken);
}
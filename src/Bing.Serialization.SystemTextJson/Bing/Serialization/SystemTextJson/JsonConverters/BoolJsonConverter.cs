using System.Text.Json.Serialization;

namespace Bing.Serialization.SystemTextJson.JsonConverters;

/// <summary>
/// <see cref="bool"/> 类型Json转换(用于将字符串类型 <see langword="true"/> 或 <see langword="false"/> 转化成后端可识别的 <see cref="bool"/> 类型)
/// </summary>
public sealed class BoolJsonConverter : JsonConverter<bool>
{
    /// <inheritdoc />
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType switch
        {
            JsonTokenType.True or JsonTokenType.False => reader.GetBoolean(),
            JsonTokenType.String => bool.Parse(reader.GetString()!),
            JsonTokenType.Number => reader.GetDouble() > 0,
            _ => throw new NotImplementedException($"un processed token type {reader.TokenType}")
        };

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) => writer.WriteBooleanValue(value);
}
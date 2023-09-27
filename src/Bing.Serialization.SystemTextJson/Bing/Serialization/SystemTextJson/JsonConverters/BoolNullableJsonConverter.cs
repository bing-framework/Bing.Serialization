using System.Text.Json.Serialization;

namespace Bing.Serialization.SystemTextJson.JsonConverters;

/// <summary>
/// 可空 <see cref="bool"/> 类型Json转换(用于将字符串类型 <see langword="true"/> 或 <see langword="false"/> 转化成后端可识别的 <see cref="bool"/> 类型)
/// </summary>
/// <example>
///  <code>
/// <![CDATA[
///  builder.Services.AddControllers().AddJsonOptions(c => c.JsonSerializerOptions.Converters.Add(new BoolNullableJsonConverter()));
///  ]]>
///  </code>
/// </example>
public class BoolNullableJsonConverter : JsonConverter<bool?>
{
    /// <inheritdoc />
    public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType switch
        {
            JsonTokenType.True or JsonTokenType.False => reader.GetBoolean(),
            JsonTokenType.Null => null,
            JsonTokenType.String => bool.Parse(reader.GetString()!),
            JsonTokenType.Number => reader.GetDouble() > 0,
            _ => throw new NotImplementedException($"un processed token type {reader.TokenType}")
        };

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
    {
        if (value is not null)
            writer.WriteBooleanValue(value.Value);
        else
            writer.WriteNullValue();
    }
}
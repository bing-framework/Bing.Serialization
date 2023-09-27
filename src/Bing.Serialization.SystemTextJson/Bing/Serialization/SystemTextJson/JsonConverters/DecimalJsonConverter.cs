using System.Globalization;
using System.Text.Json.Serialization;

namespace Bing.Serialization.SystemTextJson.JsonConverters;

/// <summary>
/// Decimal数据类型Json转换(用于将字符串类型的数字转化成后端可识别的decimal类型)
/// </summary>
public sealed class DecimalJsonConverter : JsonConverter<decimal>
{
    /// <inheritdoc />
    public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.Number
            ? reader.GetDecimal()
            : decimal.Parse(reader.GetString()!);

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString(CultureInfo.CurrentCulture));
}
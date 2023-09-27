using System.Globalization;
using System.Text.Json.Serialization;

namespace Bing.Serialization.SystemTextJson.JsonConverters;

/// <summary>
/// 可空Decimal数据类型Json转换(用于将字符串类型的数字转化成后端可识别的decimal类型)
/// </summary>
public sealed class DecimalNullableJsonConverter : JsonConverter<decimal?>
{
    /// <inheritdoc />
    public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType == JsonTokenType.Number
            ? reader.GetDecimal()
            : string.IsNullOrEmpty(reader.GetString())
                ? default(decimal?)
                : decimal.Parse(reader.GetString()!);
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options) => writer.WriteStringValue(value?.ToString(CultureInfo.CurrentCulture));
}
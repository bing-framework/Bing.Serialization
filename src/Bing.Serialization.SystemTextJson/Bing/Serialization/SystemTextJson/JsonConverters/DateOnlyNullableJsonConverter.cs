using System.Text.Json.Serialization;

namespace Bing.Serialization.SystemTextJson.JsonConverters;

#if NET6_0_OR_GREATER

/// <summary>
/// 可空 <see cref="DateOnly"/> 类型Json转换(用于将字符串类型的日期转化成后端可识别的 <see cref="DateOnly"/> 类型)
/// </summary>
public class DateOnlyNullableJsonConverter : JsonConverter<DateOnly?>
{
    /// <inheritdoc />
    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        string.IsNullOrWhiteSpace(reader.GetString())
            ? null
            : DateOnly.Parse(reader.GetString()!);

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options) => writer.WriteStringValue(value?.ToString(Constant.DateFormat));
}

#endif

namespace Bing.Serialization.SystemTextJson.JsonConverters;

/// <summary>
/// 常量
/// </summary>
internal static class Constant
{
    /// <summary>
    /// 日期格式
    /// </summary>
    internal const string DateFormat = "yyyy-MM-dd";

    /// <summary>
    /// 时间格式
    /// </summary>
    internal const string TimeFormat = "HH:mm:ss";

    /// <summary>
    /// 日期时间格式
    /// </summary>
    internal const string DateTimeFormat = $"{DateFormat} {TimeFormat}";
}
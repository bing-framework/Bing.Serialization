namespace Bing.Serialization.SystemTextJson;

/// <summary>
/// 基于 Microsoft System.Text.Json 实现的Json帮助类
/// </summary>
public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Microsoft System.Text.Json 管理器
    /// </summary>
    private static class Manager
    {
        /// <summary>
        /// Json序列化选项设置
        /// </summary>
        private static JsonSerializerOptions _options = new();

        /// <summary>
        /// 默认Json序列化选项设置
        /// </summary>
        public static JsonSerializerOptions DefaultOptions
        {
            get => _options;
            set=> _options = value??_options;
        }
    }

    /// <summary>
    /// 获取默认Json序列化选项设置
    /// </summary>
    public static JsonSerializerOptions GetDefaultOptions() => Manager.DefaultOptions;

    /// <summary>
    /// 设置默认Json序列化选项设置
    /// </summary>
    /// <param name="options">Json序列化选项设置</param>
    public static void SetDefaultOptions(JsonSerializerOptions options) => Manager.DefaultOptions = options;

    /// <summary>
    /// 转换Json序列化选项设置
    /// </summary>
    /// <param name="options">Json序列化选项设置</param>
    private static JsonSerializerOptions ToOptions(this JsonSerializerOptions options) =>
        options ?? Manager.DefaultOptions;
}
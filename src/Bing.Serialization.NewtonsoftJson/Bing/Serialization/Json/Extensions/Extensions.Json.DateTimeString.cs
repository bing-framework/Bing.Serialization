﻿using System;
using System.Text.RegularExpressions;

// ReSharper disable once CheckNamespace
namespace Bing.Serialization.Json
{
    /// <summary>
    /// Newtonsoft Json 扩展
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// 处理Json的时间格式为正常格式
        /// </summary>
        /// <param name="jsonString">Json字符串</param>
        /// <param name="format">时间格式</param>
        public static string FixJsonDateTimeFormat(this string jsonString, string format = "yyyy-MM-dd HH:mm:ss.fff") =>
            Regex.Replace(jsonString, @"\\/Date\((\d+)\)\\/",
                match => new DateTime(1970, 1, 1)
                    .AddMilliseconds(long.Parse(match.Groups[1].Value))
                    .ToLocalTime()
                    .ToString(format));
    }
}

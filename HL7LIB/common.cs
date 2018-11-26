using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HL7LIB
{
    public class common
    {
        /// <summary>
        /// 组件分隔符
        /// </summary>
        public static string componentDelimiter="^";
        public static string escapeDelimiter="\\";
        /// <summary>
        /// 字段分隔符
        /// </summary>
        public static string fieldDelimiter="|";
        /// <summary>
        /// 重复符
        /// </summary>
        public static string repeatDelimiter="~";
        /// <summary>
        /// 段分隔符
        /// </summary>
        public static string segmentDelimiter="\r";
        /// <summary>
        /// 子组件分隔符
        /// </summary>
        public static string subComponentDelimiter="&";
        public static string version="2.4";
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace YKMonitor.Util
{
    /// <summary>
    /// 业务异常 该处的异常并不会被当作真正的异常，为上层返回错误信息
    /// </summary>
    public class BusException : Exception
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public BusException()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">错误信息</param>
        public BusException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">错误信息</param>
        /// <param name="errorCode">错误代码</param>
        public BusException(string message, int errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLog
{
    /// <summary>
    /// 日志消息类型的枚举
    /// </summary>
    public enum MsgType
    {
        /// <summary>
        /// 指示未知信息类型的日志记录
        /// </summary>
        Unknown,

        /// <summary>
        /// 指示普通信息类型的日志记录
        /// </summary>
        Info,

        /// <summary>
        /// 指示警告信息类型的日志记录
        /// </summary>
        Warn,

        /// <summary>
        /// 指示错误信息类型的日志记录
        /// </summary>
        Error,

        /// <summary>
        /// 指示成功信息类型的日志记录
        /// </summary>
        Success
    }
}

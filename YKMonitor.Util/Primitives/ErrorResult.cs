using System;
using System.Collections.Generic;
using System.Text;

namespace YKMonitor.Util
{
    public class ErrorResult : AjaxResult
    {
        public ErrorResult(string msg = "操作失败!", int errorCode = 0)
        {
            Msg = msg;
            Success = false;
            ErrorCode = errorCode;
        }
    }
}

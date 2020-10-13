using System;
using System.Collections.Generic;
using System.Text;

namespace YKMonitor.Util
{
    public class JWTPayload
    {
        public string UserId { get; set; }
        public DateTime Expire { get; set; }
    }
}

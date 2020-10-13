using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YKMonitor.Entity.Base_Manage
{
    [Table("TK_Robot")]
    public class RobotEntity:BaseEntity
    {
        public int MyProperty { get; set; }
    }
}

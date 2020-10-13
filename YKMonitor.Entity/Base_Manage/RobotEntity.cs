using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YKMonitor.Entity.Base_Manage
{
    [Table("TK_Robot")]
    public class RobotEntity:BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string robot_name { get; set; }
    }
}

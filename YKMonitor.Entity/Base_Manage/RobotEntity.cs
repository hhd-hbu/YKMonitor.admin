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
        /// 机器人名称
        /// </summary>
        public string robot_name { get; set; }
        /// <summary>
        /// 机器人链接
        /// </summary>
        public string link { get; set; }
        /// <summary>
        /// 短信
        /// </summary>
        public string shortmessage { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public string founder_id { get; set; }
        /// <summary>
        /// 修改人id
        /// </summary>
        public string modifier_id { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime modifier_time { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remarks { get; set; }
    }
}

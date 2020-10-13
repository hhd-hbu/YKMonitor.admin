using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YKMonitor.Entity.Base_Manage
{
    /// <summary>
    /// 规则表
    /// </summary>
    [Table("YK_Rule")]
    class RuleEntity:BaseEntity
    {
        /// <summary>
        /// 规则 日期类型 0:选择日期,1:每周
        /// </summary>
        public bool date_type { get; set; }
        /// <summary>
        /// 类型0 :月
        /// </summary>
        public int date_type_month { get; set; }
        /// <summary>
        /// 类型0 :日
        /// </summary>
        public int date_type_day { get; set; }
        /// <summary>
        /// 类型1 :星期选择 如1,2,3,4,5,6,7
        /// </summary>
        public string  date_type_week { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime time_start { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime time_end { get; set; }
        /// <summary>
        /// 规则 时间类型 0:执行一次 ,1 :循环执行
        /// </summary>
        public bool time_type { get; set; }
        /// <summary>
        /// 循环执行秒
        /// </summary>
        public int loop_second { get; set; }
    }
}

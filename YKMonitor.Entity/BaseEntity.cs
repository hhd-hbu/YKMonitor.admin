using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YKMonitor.Entity
{
    /// <summary>
    /// 数据库映射基类
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key, Column(Order = 1)]
        public string Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime create_time { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int state { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public Boolean is_deleted { get; set; }
    }
}

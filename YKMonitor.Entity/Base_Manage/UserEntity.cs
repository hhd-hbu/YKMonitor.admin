using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YKMonitor.Entity.Base_Manage
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("YK_User")]
    public class UserEntity:BaseEntity
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
    }
}

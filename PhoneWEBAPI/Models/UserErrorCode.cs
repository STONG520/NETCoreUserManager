using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWEBAPI.Models
{
    public enum UserErrorCode
    {
        /// <summary>
        /// 登录成功
        /// </summary>
        OK=0,
        /// <summary>
        /// 用户名不存在
        /// </summary>
        USERNAMEERROR=1,
        /// <summary>
        /// 密码错误
        /// </summary>
        USERPWDERROR=2
    }
}

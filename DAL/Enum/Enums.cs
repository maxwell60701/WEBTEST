using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enums
{
    public class Enums
    {
        /// <summary>
        /// 错误异常
        /// </summary>
        public enum EnumError
        {
            正常=200,
            异常=400
        }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public enum EnumDataBase
        {
           sqlserver=1,
           mysql=2,
           oracle=3
           
        }

    }
}

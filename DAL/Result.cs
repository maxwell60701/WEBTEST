using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Enums.Enums;

namespace DAL
{
    public class Result<T>
    {
        public Result(T data)
        {
            Data = data;
        }
        public Result()
        {

        }
        public EnumError ErrorCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int TotalCount { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
    /// <summary>
    /// 登录信息
    /// </summary>
    public class LoginInfo
    {
        public string UserName { get; set; }

        public string PassWord { get; set; }
    }

}

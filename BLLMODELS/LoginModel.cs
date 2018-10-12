using DAL;
using DAL.database;
using DAL.database.mysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Enums.Enums;

namespace BLLMODELS
{
    public class LoginModel
    {
        private readonly WEBMODEL _webmodels;
        public LoginModel(WEBMODEL webmodel)
        {
            _webmodels = webmodel;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="logininfo"></param>
        /// <returns></returns>
        public bool Login(LoginInfo logininfo)
        {
            var password = Helpers.MD5Encrypt32(logininfo.PassWord);
            var log = _webmodels.users.FirstOrDefault(u => u.UserName == logininfo.UserName && u.Password == password);
            if (log == null)
                return false;
            return true;
        }
        /// <summary>
        /// 返回数据库EF实体类
        /// </summary>
        /// <param name="enumdatabase"></param>
        /// <returns></returns>
        public static WEBMODEL Getdatabase(int enumdatabase)
        {

            if (enumdatabase == Convert.ToInt32(EnumDataBase.sqlserver))
                return new sqlWEBMODEL();
            else if (enumdatabase == Convert.ToInt32(EnumDataBase.mysql))
                return new mqwebmodel();
            else
                return new sqlWEBMODEL();


        }
    }
}

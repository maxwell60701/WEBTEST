using DAL;
using DAL.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var log = _webmodels.Users.FirstOrDefault(u => u.UserName == logininfo.UserName && u.Password == password);
            if (log == null)
                return false;
            return true;
        }
    }
}

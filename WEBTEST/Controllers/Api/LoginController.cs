using BLLMODELS;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static DAL.Enums.Enums;

namespace WEBTEST.Controllers.Api
{
    public class LoginController : ApiController
    {
        // GET: Login
        public async Task<HttpResponseMessage> Login(LoginInfo logininfo)
        {
            var result = new HttpResponseMessage();
            string msg = "";
            var data = "";
            var resultmodel = new Result<string>();
            try
            {
                LoginModel loginmodel = new LoginModel();               
                var DATA = await Task.Run(() => loginmodel.Login(logininfo)); ;
                data = Helpers.DataToJson(DATA);
                resultmodel = new Result<string>(data) { ErrorCode = EnumError.正常 };
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                resultmodel = new Result<string>(data) { ErrorCode = EnumError.异常 };
            }
            finally
            {
                result.Content = new StringContent(Helpers.DataToJson(resultmodel), Encoding.GetEncoding("UTF-8"),
                            "application/json");
                
            }
            return  result;
        }
       
        
    }
}
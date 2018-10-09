using BLLMODELS;
using DAL;
using DAL.database;
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
        private readonly WEBMODEL _webmodels;
        private LoginModel loginmodel;
        public LoginController()
        {
            _webmodels = new WEBMODEL();
            loginmodel = new LoginModel(_webmodels);
        }
        // GET: Login
        //[System.Web.Http.HttpGet]
        //[System.Web.Http.HttpPost]
        //public async Task<HttpResponseMessage> LoginAsync([FromBody]LoginInfo logininfo)
        //{
        //    var result = new HttpResponseMessage();
        //    string msg = "";
        //    var data = "";
        //    var resultmodel = new Result<string>();
        //    try
        //    {
        //        var DATA = await Task.Run(() => loginmodel.Login(logininfo)); ;
        //        data = Helpers.DataToJson(DATA);
        //        resultmodel = new Result<string>(data) { ErrorCode = EnumError.正常 };
        //    }
        //    catch (Exception ex)
        //    {
        //        msg = ex.Message;
        //        resultmodel = new Result<string>(data) { ErrorCode = EnumError.异常 };
        //    }
        //    finally
        //    {
        //        result.Content = new StringContent(Helpers.DataToJson(resultmodel), Encoding.GetEncoding("UTF-8"),
        //                    "application/json");

        //    }
        //    return result;
        //}
        [System.Web.Http.HttpGet]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage PostLogin([FromBody]LoginInfo logininfo)
        {
            var result = new HttpResponseMessage();
            string msg = "";
            var data = "";
            var resultmodel = new Result<string>();
            try
            {
                var DATA = loginmodel.Login(logininfo);
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
            return result;
        }


    }
}
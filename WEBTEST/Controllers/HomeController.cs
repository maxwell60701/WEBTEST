using BLLMODELS;
using DAL;
using DAL.database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using static DAL.Enums.Enums;

namespace WEBTEST.Controllers
{
    public class HomeController : Controller
    {
        private LoginModel loginmodel;
        private WEBMODEL _webmodels;
        private Cache cache;
        private string MachineNumber = Helpers.GetMachineNum();
        public HomeController()
        {
            _webmodels = LoginModel.Getdatabase(Convert.ToInt32(ConfigurationManager.AppSettings["database"]));
            loginmodel = new LoginModel(_webmodels);
            cache = new Cache();
        }

        public ActionResult Index(string username)
        {
            ViewBag.UserName = username;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            if (cache.Get("MachineNumber") == null)
                return View();
            if (cache.Get("MachineNumber").ToString() == MachineNumber)
            {
                ViewBag.UserName = cache.Get("UserName").ToString();
                return View("Index");
            }
            else
                return View();
        }
        public ActionResult ToLogin()
        {
            return View("Login");
        }
        public ActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="logininfo"></param>
        /// <returns></returns>
        public async Task<JsonResult> PostLoginAsync(LoginInfo logininfo)
        {
            var result = new JsonResult();
            string msg = "";
            var data = "";
            var resultmodel = new Result<string>();
            try
            {
                var DATA = await Task.Run(() => loginmodel.Login(logininfo)); ;
                data = Helpers.DataToJson(DATA);
                resultmodel = new Result<string>(data) { ErrorCode = EnumError.正常 };
                if (cache.Get("MachineNumber") == null)
                {
                    cache.Add("MachineNumber", MachineNumber, null, DateTime.Now.AddDays(3), Cache.NoSlidingExpiration, CacheItemPriority.Low, null);
                    cache.Add("UserName", logininfo.UserName, null, DateTime.Now.AddDays(3), Cache.NoSlidingExpiration, CacheItemPriority.Low, null);
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                resultmodel = new Result<string>(data) { ErrorCode = EnumError.异常 };
            }
            finally
            {
                result.ContentEncoding = Encoding.GetEncoding("UTF-8");
                result.ContentType = "application/json";
                result.Data = Helpers.DataToJson(resultmodel);
            }
            return result;
        }

    }
}
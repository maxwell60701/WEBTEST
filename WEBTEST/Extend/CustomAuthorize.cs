using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBTEST.Extend
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public static string MachineNumber = Helpers.GetMachineNum();

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            
            if (HttpRuntime.Cache != null)
            {
                if (HttpRuntime.Cache["MachineNumber"].ToString() == MachineNumber)
                {
                   
                    filterContext.Result = new RedirectResult("~/Home/Index");
                }
            }
            else
            {
                return;
            }
        }
    }
}
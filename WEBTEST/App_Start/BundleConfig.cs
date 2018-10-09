using System.Web;
using System.Web.Optimization;

namespace WEBTEST
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 https://modernizr.com 上的生成工具仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery-1.10.2.min.js",
                       "~/Scripts/jquery-1.10.2.js",
                       "~/Scripts/supersized-init.js",
                        "~/Scripts/supersized.3.2.7.min.js",
                          "~/Scripts/supersized.3.2.7.min.js"


                        ));
            bundles.Add(new ScriptBundle("~/bundles/scroll").Include(
                              "~/Scripts/myscroll.js",
                               "~/Scripts/bootstrap.js",
                                "~/Scripts/respond.js",
                               "~/Scripts/jquery-1.10.2.min.js",
                                "~/Scripts/jquery-1.10.2.js",
                                "~/Scripts/jquery.min.js",
                                "~/Scripts/jq22.js",
                                "~/Scripts/common.js",
                                "~/Scripts/jquery-latest.min.js"

                          ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                     "~/Content/reset.css",
                      "~/Content/style.css",
                       "~/Content/supersized.css",
                       "~/Content/index.css",
                       "~/Content/jq22.css"));
            bundles.Add(new StyleBundle("~/Content/Index").Include(
                    "~/Content/bootstrap.css",                  
                     "~/Content/icon-component.css",
                     "~/Content/index.css",
                     "~/Content/jq22.css"
                    ));

        }
    }
}

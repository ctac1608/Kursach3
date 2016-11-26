using System.Web;
using System.Web.Optimization;

namespace Kursach3
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.rateyo.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularApp").Include(
                      "~/Scripts/app.js",
                      "~/Scripts/Controllers/popularCreativeController.js",
                      "~/Scripts/Controllers/newCreativeController.js",
                      "~/Scripts/Controllers/userDataController.js",
                      "~/Scripts/Controllers/userCreativesController.js",
                      "~/Scripts/Controllers/addController.js",
                      "~/Scripts/Controllers/readController.js",
                      "~/Scripts/Services/homePageService.js",
                      "~/Scripts/Services/userPageService.js",
                      "~/Scripts/Directives/modalDialog.js",
                      "~/Scripts/Directives/tagInput.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/search.css",
                      "~/Content/creative-reader-style.css",
                      "~/Content/day-night-ru-en-style.css",
                      "~/Content/tag-style.css",
                      "~/Content/creating-style.css",
                      "~/Content/userpage.css",
                      "~/Content/jquery.rateyo.css",
                      "~/Content/summernote.css"));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace Education2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Content/assets/js/jquery.js" ,

                "~/Content/assets/js/jquery.select2/select2.min.js",
                "~/Content/assets/js/jquery.parsley/parsley.js",
                "~/Content/assets/js/bootstrap.slider/js/bootstrap-slider.js",
                "~/Content/assets/js/jquery.nanoscroller/jquery.nanoscroller.js",
                "~/Content/assets/js/jquery.nestable/jquery.nestable.js",
                "~/Content/assets/js/behaviour/general.js",
                "~/Content/assets/js/jquery.ui/jquery-ui.js",
                "~/Content/assets/js/jquery.nestable/jquery.nestable.js",
                "~/Content/assets/js/bootstrap.switch/bootstrap-switch.min.js",
                "~/Content/assets/js/bootstrap.datetimepicker/js/bootstrap-datetimepicker.min.js",
                "~/Content/assets/js/jquery.icheck/icheck.min.js",
                "~/Content/assets/js/jquery.datatables/jquery.datatables.min.js",
                "~/Content/assets/js/jquery.datatables/bootstrap-adapter/js/datatables.js",
                "~/Content/assets/js/behaviour/voice-commands.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/assets/js/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/assets/js/bootstrap/dist/css/bootstrap.css",
                "~/Content/assets/js/bootstrap.switch/bootstrap-switch.css",
                "~/Content/assets/js/bootstrap.datetimepicker/css/bootstrap-datetimepicker.min.css",
                "~/Content/assets/js/jquery.select2/select2.css",
                "~/Content/assets/js/bootstrap.slider/css/slider.css",
                "~/Content/assets/css/style.css",
                "~/Content/assets/fonts/font-awesome-4/css/font-awesome.min.css",
                "~/Content/assets/css/pygments.css",
                "~/Content/assets/js/jquery.nanoscroller/nanoscroller.css",
                "~/Content/assets/js/jquery.icheck/skins/square/blue.css",
                      "~/Content/site.css"));
        }

       
         
    }
}

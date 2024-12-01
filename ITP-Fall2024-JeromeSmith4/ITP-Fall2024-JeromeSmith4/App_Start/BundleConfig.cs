using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using ITP245_Sports_Model;

namespace ITP_Fall2024_JeromeSmith4
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            using (var entities = new SportsEntities())
            {

                var options = entities.SystemOptions.First();
                bundles.Add(new StyleBundle("~/Content/css").Include(
                          //"~/Content/Pulse.css",
                          //$"~/Content/{ConfigurationManager.AppSettings["Bootstrap"]}.css",
                          //"~/Content/Sports.css",
                          $"~/Content/{options.Bootstrap}.css",
                          "~/Content/site.css"));
            }
            }
        }
}

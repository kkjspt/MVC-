using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/js/jquery").Include("~/Content/js/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/Content/js").Include("~/Content/js/jquery*"));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/counter.js",
                "~/Content/js/custom.js",
                "~/Content/js/excanvas.js",
                "~/Content/js/fullcalendar.min.js",
                "~/Content/js/modernizr.js",
                "~/Content/js/retina.js",
                ""));
            bundles.Add(new StyleBundle("~/Content/css/bootsrap").Include("~/Content/css/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/bootstrap-responsive.min").Include("~/Content/css/bootstrap-responsive.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/style").Include("~/Content/css/style.css"));
            bundles.Add(new StyleBundle("~/Content/css/style-responsive").Include("~/Content/css/style-responsive.css"));
            bundles.Add(new StyleBundle("~/Content/css/bootsrap").Include("~/Content/css/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/bootsrap").Include("~/Content/css/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/bootsrap").Include("~/Content/css/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/bootsrap").Include("~/Content/css/bootstrap.min.css"));

        }
    }
}
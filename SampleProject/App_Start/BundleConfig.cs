using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SampleProject.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection vrpBundleCollection)
        {
            vrpBundleCollection.Add(new StyleBundle("~/MojeCss")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/site.css"));
        }
    }
}
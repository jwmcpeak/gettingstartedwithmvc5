using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FirstController
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include("~/scripts/one.js")
                .Include("~/scripts/two.js")
                .Include("~/scripts/three.js")
                .Include("~/scripts/four-{version}.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
﻿using System.Web.Optimization;

namespace JJ.Presentation.QuestionAndAnswer.Mvc
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
        }
    }
}
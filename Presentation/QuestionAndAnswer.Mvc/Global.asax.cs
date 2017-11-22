﻿using JJ.Framework.Common;
using JJ.Framework.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using JJ.Presentation.QuestionAndAnswer.Mvc.App_Start;

namespace JJ.Presentation.QuestionAndAnswer.Mvc
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			DispatcherConfig.AddMappings();

			var config = CustomConfigurationManager.GetSection<JJ.Presentation.QuestionAndAnswer.Configuration.ConfigurationSection>();
			ConfigurationHelper.SetSection(config);
	   }
	}
}
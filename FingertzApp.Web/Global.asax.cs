using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FingertzApp.Web
{
    using System.Web.Http.Dispatcher;

    using Castle.Windsor;

    using FingertzApp.Web.CastleDI;
    using FingertzApp.Web.Mapping;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
          private readonly IWindsorContainer container;

          public MvcApplication()
        {
            this.container =
                new WindsorContainer().Install(new DependencyInstaller());

            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container.Kernel));

            AutoMapperConfiguration.Configure();
        }

        public override void Dispose()
        {
            this.container.Dispose();
            base.Dispose();
        }
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            GlobalConfiguration.Configuration.Services.Replace(
             typeof(IHttpControllerActivator),
             new WindsorActivator(this.container));
        }
    }
}
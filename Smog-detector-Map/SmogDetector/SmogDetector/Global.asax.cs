using Autofac;
using Autofac.Integration.Mvc;
using Giphy;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace SmogDetector
{
    public class MvcApplication : System.Web.HttpApplication
    {
       
        protected void Application_Start()
        {
          
            RegisterComponents(new ContainerBuilder());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        private IContainer RegisterComponents(ContainerBuilder builder)
        {
          builder.RegisterType<FunnyService>().As<IFunnyService>().InstancePerLifetimeScope();

            var container = builder.Build();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var dd = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(dd);
            return container;

            
           
        }
    }
}
                                                                                                                                            
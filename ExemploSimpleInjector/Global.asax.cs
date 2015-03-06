using ExemploSimpleInjector.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExemploSimpleInjector
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            SimpleInjectorConfig.ConfigureSimpleInjector();
        }
    }
}

using ExemploSimpleInjector.Contexts;
using ExemploSimpleInjector.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
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

            //Configuração do Simple Injector
            var container = new Container();

            container.RegisterPerWebRequest<DataContext, DataContext>();
            container.Register<IClienteRepository, ClienteRepository>();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}

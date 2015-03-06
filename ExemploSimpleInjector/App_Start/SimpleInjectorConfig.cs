using ExemploSimpleInjector.Contexts;
using ExemploSimpleInjector.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;

namespace ExemploSimpleInjector.App_Start
{
    public class SimpleInjectorConfig
    {

        public static void ConfigureSimpleInjector()
        {
            var container = new Container();

            container.RegisterPerWebRequest<DataContext, DataContext>();
            container.Register<IClienteRepository, ClienteRepository>();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

    }
}
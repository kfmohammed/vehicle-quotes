using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ALDQuoteService.Services;
using Autofac;
using Autofac.Integration.WebApi;
using AutoFacWithWebAPI.App_Start;

namespace ALDQuoteService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterModule(new AutofacWebTypesModule());
            ////builder.RegisterControllers(typeof(ApiController).Assembly);

            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterSource(new ViewRegistrationSource());

            //builder.RegisterType<QuoteService>().As<IQuoteService>();
            //builder.RegisterType<VehicleService>().As<IVehicleService>();

            //var container = builder.Build();

            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //GlobalConfiguration.Configuration.DependencyResolver =
            //    new AutofacDependencyResolver(container);

            AutofacWebapiConfig.Initialize(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}

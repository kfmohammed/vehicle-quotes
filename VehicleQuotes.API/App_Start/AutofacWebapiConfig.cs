using ALDQuoteService.Services;
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using ALDQuoteService.QuoteEngines;

namespace AutoFacWithWebAPI.App_Start
{
    public class AutofacWebapiConfig
    {

        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //builder.RegisterType<DBCustomerEntities>()
            //    .As<DbContext>()
            //    .InstancePerRequest();

            builder.RegisterType<QuoteService>()
                .As<IQuoteService>()
                .InstancePerRequest();

            builder.RegisterType<VehicleService>()
                .As<IVehicleService>()
                .InstancePerRequest();

            builder.RegisterType<QuoteEngineFactory>()
                .As<QuoteEngineFactory>()
                .InstancePerRequest();

            //builder.RegisterGeneric(typeof(GenericRepository<>))
            //    .As(typeof(IGenericRepository<>))
            //    .InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }

    }
}
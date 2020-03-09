[assembly: WebActivator.PostApplicationStartMethod(typeof(CitelProject.API.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace CitelProject.API.App_Start
{
    using System.Web.Http;
    using CitelProject.Application;
    using CitelProject.Application.Interface;
    using CitelProject.Domain.Interfaces.Repositories;
    using CitelProject.Domain.Interfaces.Services;
    using CitelProject.Domain.Services;
    using CitelProject.Infra.Data.Repositories;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using SimpleInjector.Lifestyles;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            // For instance:
            container.Register<ICategoryAppService, CategoryAppService>(Lifestyle.Scoped);
            container.Register<ICategoryService, CategoryService>(Lifestyle.Scoped);
            container.Register<ICategoryRepository, CategoryRepository>(Lifestyle.Scoped);

            container.Register<IProductAppService, ProductAppService>(Lifestyle.Scoped);
            container.Register<IProductService, ProductService>(Lifestyle.Scoped);
            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);
        }
    }
}
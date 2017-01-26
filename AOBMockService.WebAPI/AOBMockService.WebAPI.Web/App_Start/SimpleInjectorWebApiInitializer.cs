using System;
using System.Collections.Generic;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Reflection;
using AOBMockService.WebAPI.Quote;
using AOBMockService.WebAPI.ThirdParties;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(AOBMockService.WebAPI.Web.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace AOBMockService.WebAPI.Web.App_Start
{
    public class SimpleInjectorWebApiInitializer
    {
        public static void Initialize()
        {
            var container = new Container();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            InitializeQuoteDependencies(container);
            InitializeThirdPartiesDependencies(container);      
        }

        private static void InitializeQuoteDependencies(Container container)
        {
            container.Register<IQuoteService, QuoteService>();
        }

        private static void InitializeThirdPartiesDependencies(Container container)
        {
            container.Register<IGoogleMapService, GoogleMapService>();
        }
    }
}
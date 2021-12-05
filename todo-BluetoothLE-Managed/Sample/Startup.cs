﻿using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Prism.Ioc;
using Prism.Navigation;
using Shiny;
using Xamarin.Forms;

namespace Sample
{
    public class Startup : FrameworkStartup
    {
        public override void ConfigureApp(Application app, IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TabbedPage>();
            containerRegistry.RegisterForNavigation<MainPage>();

            
        }


        public override Task RunApp(INavigationService navigator)
        {
            throw new System.NotImplementedException();
        }


        protected override void Configure(ILoggingBuilder builder, IServiceCollection services)
        {
            services.UseBleClient();

            services.UseGlobalCommandExceptionHandler();
            services.UseXfMaterialDialogs();
        }
    }
}

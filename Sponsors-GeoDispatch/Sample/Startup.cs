﻿using Shiny;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Prism.Ioc;
using Prism.Navigation;
using Xamarin.Forms;


namespace Sample
{
    public class Startup : FrameworkStartup
    {
        public override void ConfigureApp(Application app, IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LogsPage, LogsViewModel>();
            containerRegistry.RegisterForNavigation<PendingPage, PendingViewModel>();
            containerRegistry.RegisterForNavigation<SendPage, SendViewModel>();
        }


        public override Task RunApp(INavigationService navigator)
            => navigator.Navigate("NavigationPage/MainPage");


        protected override void Configure(ILoggingBuilder builder, IServiceCollection services)
        {
            // we inject our db so we can use it in our shiny background events to store them for display later
            services.UseGlobalCommandExceptionHandler();
            services.UseXfMaterialDialogs();
            services.AddSingleton<SampleSqliteConnection>();
            services.UseGeoDispatch<SampleGeoDispatchDelegate>();

            // note that we're using the empty push delegate because we aren't interested in processing our own push events, geodispatch will be handling them
            services.UsePushAzureNotificationHubs<Shiny.Push.Common.EmptyPushDelegate>(
                Secrets.Values.AzureNotificationHubFullConnectionString,
                Secrets.Values.AzureNotificationHubName
            );
        }
    }
}

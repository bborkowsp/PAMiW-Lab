﻿﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls;
using P04WeatherForecastAPI.Client.ViewModels;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.AuthService;
using P06Shop.Shared.Services.VehicleDealershipService;
using P12MAUI.Client.MessageBox;
using P12MAUI.Client.ViewModels;
using System.Diagnostics;

namespace P12MAUI.Client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif


            ConfigureServices(builder.Services);
            return builder.Build();
        }


        private static void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = ConfigureAppSettings(services);
            ConfigureAppServices(services, appSettingsSection);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettingsSection);
        }

        private static AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            // pobranie appsettings z konfiguracji i zmapowanie na klase AppSettings 
            //Microsoft.Extensions.Options.ConfigurationExtensions
            //var appSettings = _configuration.GetSection(nameof(AppSettings));
            //var appSettingsSection = appSettings.Get<AppSettings>();
            // services.Configure<AppSettings>(appSettings);

            string workingDirectory = AppContext.BaseDirectory;
            string projectDir = Directory.GetParent(workingDirectory).Parent.Parent.Parent.Parent.Parent.FullName;

            string s = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder()
              .AddUserSecrets<MauiApp>()
              .SetBasePath(projectDir)
              .AddJsonFile("appsettings.json");
            IConfiguration _configuration = builder.Build();

            var appSettings = _configuration.GetSection(nameof(AppSettings));
            var appSettingsSection = appSettings.Get<AppSettings>();



            services.AddSingleton(appSettingsSection);


            return appSettingsSection;
        }

        private static void ConfigureAppServices(IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton<IConnectivity>(Connectivity.Current);
            services.AddSingleton<IGeolocation>(Geolocation.Default);
            services.AddSingleton<IMap>(Map.Default);

            // konfiguracja serwisów 
            services.AddSingleton<IVehicleDealershipService, VehicleDealershipService>();
            services.AddSingleton<IMessageDialogService, MauiMessageDialogService>();

        }

        private static void ConfigureViewModels(IServiceCollection services)
        {

            // konfiguracja viewModeli 


            services.AddSingleton<VehiclesViewModel>();
            services.AddTransient<VehicleDetailsViewModel>();
            //services.AddSingleton<LoginViewModel>();

        }

        private static void ConfigureViews(IServiceCollection services)
        {
            // konfiguracja okienek 
            services.AddSingleton<MainPage>();    
            services.AddTransient<VehicleDetailsView>();
            //services.AddTransient<LoginView>();
        }

        private static void ConfigureHttpClients(IServiceCollection services, AppSettings appSettingsSection)
        {
            var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {
            };
            //Microsoft.Extensions.Http
            services.AddHttpClient<IVehicleDealershipService, VehicleDealershipService>(client => client.BaseAddress = uriBuilder.Uri);
            services.AddHttpClient<IAuthService, AuthService>(client => client.BaseAddress = uriBuilder.Uri);
        }
    }
}
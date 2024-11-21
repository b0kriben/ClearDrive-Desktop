using cleardrive.desktop;
using cleardrive.desktop.Extensions;
using cleardrive.desktop.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
//using Application = System.Windows.Application;

namespace cleardrive.desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        // Az alkalmazás indítása
        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();

            // Konfiguráljuk a DI konténert
            serviceCollection.AddSingleton<MainViewModel>();
            serviceCollection.AddSingleton<MainWindow>();
            serviceCollection.ConfigureViewViewModels(); // A kiterjesztés

            // Létrehozzuk a ServiceProvider-t
            ServiceProvider = serviceCollection.BuildServiceProvider();

            // Az alkalmazás indítása
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        /*public App()
        {
            host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.ConfigureViewViewModels();
                services.ConfigureHttpCliens();
            });
        }*/
    }

}

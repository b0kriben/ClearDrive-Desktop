using Microsoft.Extensions.DependencyInjection;
using cleardrive.desktop;
using cleardrive.desktop.ViewModels;
using Models;

namespace cleardrive.desktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

        }
    }
}

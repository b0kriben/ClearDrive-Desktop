using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cleardrive.desktop.Services;
using Microsoft.Extensions.DependencyInjection;
using Models;

namespace cleardrive.desktop.Extensions
{
    public static class ApiServiceExtensions
    {
        public static void ConfigureApiServices(this IServiceCollection services)
        {
            services.AddScoped<IClearDriveDesktopService, ClearDriveDesktopService>();
        }
    }
}

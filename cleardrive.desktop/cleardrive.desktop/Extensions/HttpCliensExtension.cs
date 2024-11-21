﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Models;

namespace cleardrive.desktop.Extensions
{
    public static class HttpCliensExtension
    {
        public static void ConfigureHttpCliens(this IServiceCollection services)
        {
            services.AddHttpClient("ClearDriveApi", options =>
            {
                options.BaseAddress = new Uri("**Eleresi utvonal**");
            });
        }

    }
}
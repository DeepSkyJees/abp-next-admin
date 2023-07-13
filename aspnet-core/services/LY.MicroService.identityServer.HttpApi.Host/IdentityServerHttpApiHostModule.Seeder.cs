using LY.MicroService.IdentityServer.DataSeeder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LY.MicroService.IdentityServer;

public partial class IdentityServerHttpApiHostModule
{
    private static void ConfigureSeedWorker(IServiceCollection services, bool isDevelopment = false)
    {
        if (isDevelopment)
        {
            services.AddHostedService<IdentityDataSeederWorker>();
        }
    }
}

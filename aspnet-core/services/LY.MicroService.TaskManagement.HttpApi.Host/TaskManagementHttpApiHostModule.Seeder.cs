using LY.MicroService.TaskManagement.DataSeeder;
using Microsoft.Extensions.DependencyInjection;

namespace LY.MicroService.TaskManagement;

public partial class TaskManagementHttpApiHostModule
{
    private static void ConfigureSeedWorker(IServiceCollection services, bool isDevelopment = false)
    {
        if (isDevelopment)
        {
            services.AddHostedService<TaskManagementDataSeederWorker>();
        }
    }
}
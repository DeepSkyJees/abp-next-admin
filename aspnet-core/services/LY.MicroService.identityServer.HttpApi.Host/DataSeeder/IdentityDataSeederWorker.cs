using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using System.Threading;
using Volo.Abp.Data;

namespace LY.MicroService.IdentityServer.DataSeeder;

public class IdentityDataSeederWorker : BackgroundService
{
    protected IDataSeeder DataSeeder { get; }

    public IdentityDataSeederWorker(IDataSeeder dataSeeder)
    {
        DataSeeder = dataSeeder;
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await DataSeeder.SeedAsync();
    }
}
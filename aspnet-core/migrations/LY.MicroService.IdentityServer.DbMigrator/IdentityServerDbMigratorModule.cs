using LINGYUN.Abp.Identity;
using LY.MicroService.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LY.MicroService.IdentityServer.DbMigrator;

[DependsOn(
    typeof(IdentityServerMigrationsEntityFrameworkCoreModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpAutofacModule)
    )]
public partial class IdentityServerDbMigratorModule : AbpModule
{
}

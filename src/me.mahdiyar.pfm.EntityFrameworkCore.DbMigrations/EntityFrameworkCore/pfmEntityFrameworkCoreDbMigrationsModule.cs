using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace me.mahdiyar.pfm.EntityFrameworkCore
{
    [DependsOn(
        typeof(pfmEntityFrameworkCoreModule)
        )]
    public class pfmEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<pfmMigrationsDbContext>();
        }
    }
}

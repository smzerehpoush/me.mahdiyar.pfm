using me.mahdiyar.pfm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace me.mahdiyar.pfm.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(pfmEntityFrameworkCoreDbMigrationsModule),
        typeof(pfmApplicationContractsModule)
        )]
    public class pfmDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

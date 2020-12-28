using Volo.Abp.Modularity;

namespace me.mahdiyar.pfm
{
    [DependsOn(
        typeof(pfmApplicationModule),
        typeof(pfmDomainTestModule)
        )]
    public class pfmApplicationTestModule : AbpModule
    {

    }
}
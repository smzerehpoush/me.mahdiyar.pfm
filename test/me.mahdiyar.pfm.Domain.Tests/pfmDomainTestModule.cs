using me.mahdiyar.pfm.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace me.mahdiyar.pfm
{
    [DependsOn(
        typeof(pfmEntityFrameworkCoreTestModule)
        )]
    public class pfmDomainTestModule : AbpModule
    {

    }
}
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace me.mahdiyar.pfm.Data
{
    /* This is used if database provider does't define
     * IpfmDbSchemaMigrator implementation.
     */
    public class NullpfmDbSchemaMigrator : IpfmDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
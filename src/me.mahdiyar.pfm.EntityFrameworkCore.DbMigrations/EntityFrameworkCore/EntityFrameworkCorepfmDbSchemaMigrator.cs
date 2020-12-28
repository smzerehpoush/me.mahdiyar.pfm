using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using me.mahdiyar.pfm.Data;
using Volo.Abp.DependencyInjection;

namespace me.mahdiyar.pfm.EntityFrameworkCore
{
    public class EntityFrameworkCorepfmDbSchemaMigrator
        : IpfmDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorepfmDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the pfmMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<pfmMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
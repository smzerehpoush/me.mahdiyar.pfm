using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace me.mahdiyar.pfm.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class pfmMigrationsDbContextFactory : IDesignTimeDbContextFactory<pfmMigrationsDbContext>
    {
        public pfmMigrationsDbContext CreateDbContext(string[] args)
        {
            pfmEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<pfmMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new pfmMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../me.mahdiyar.pfm.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

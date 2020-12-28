using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace me.mahdiyar.pfm.EntityFrameworkCore
{
    public static class pfmDbContextModelCreatingExtensions
    {
        public static void Configurepfm(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(pfmConsts.DbTablePrefix + "YourEntities", pfmConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
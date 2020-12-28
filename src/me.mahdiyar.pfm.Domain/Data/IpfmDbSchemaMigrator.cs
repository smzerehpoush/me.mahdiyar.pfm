using System.Threading.Tasks;

namespace me.mahdiyar.pfm.Data
{
    public interface IpfmDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

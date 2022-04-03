using System.Threading.Tasks;

namespace Behzad.Data;

public interface IBehzadDbSchemaMigrator
{
    Task MigrateAsync();
}

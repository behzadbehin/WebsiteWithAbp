using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Behzad.Data;

/* This is used if database provider does't define
 * IBehzadDbSchemaMigrator implementation.
 */
public class NullBehzadDbSchemaMigrator : IBehzadDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

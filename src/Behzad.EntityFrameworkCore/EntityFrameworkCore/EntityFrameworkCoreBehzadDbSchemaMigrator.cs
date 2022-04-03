using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Behzad.Data;
using Volo.Abp.DependencyInjection;

namespace Behzad.EntityFrameworkCore;

public class EntityFrameworkCoreBehzadDbSchemaMigrator
    : IBehzadDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBehzadDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BehzadDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BehzadDbContext>()
            .Database
            .MigrateAsync();
    }
}

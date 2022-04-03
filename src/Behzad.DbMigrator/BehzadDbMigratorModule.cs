using Behzad.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Behzad.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BehzadEntityFrameworkCoreModule),
    typeof(BehzadApplicationContractsModule)
    )]
public class BehzadDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}

using Volo.Abp.Modularity;

namespace Behzad;

[DependsOn(
    typeof(BehzadApplicationModule),
    typeof(BehzadDomainTestModule)
    )]
public class BehzadApplicationTestModule : AbpModule
{

}

using Behzad.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Behzad;

[DependsOn(
    typeof(BehzadEntityFrameworkCoreTestModule)
    )]
public class BehzadDomainTestModule : AbpModule
{

}

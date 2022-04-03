using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Behzad.Web;

[Dependency(ReplaceServices = true)]
public class BehzadBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Behzad";
}

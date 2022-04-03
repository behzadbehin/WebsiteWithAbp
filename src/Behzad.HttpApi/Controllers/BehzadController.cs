using Behzad.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Behzad.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BehzadController : AbpControllerBase
{
    protected BehzadController()
    {
        LocalizationResource = typeof(BehzadResource);
    }
}

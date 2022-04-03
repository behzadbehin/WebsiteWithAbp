using Behzad.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Behzad.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BehzadPageModel : AbpPageModel
{
    protected BehzadPageModel()
    {
        LocalizationResourceType = typeof(BehzadResource);
    }
}

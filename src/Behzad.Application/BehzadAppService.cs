using System;
using System.Collections.Generic;
using System.Text;
using Behzad.Localization;
using Volo.Abp.Application.Services;

namespace Behzad;

/* Inherit your application services from this class.
 */
public abstract class BehzadAppService : ApplicationService
{
    protected BehzadAppService()
    {
        LocalizationResource = typeof(BehzadResource);
    }
}

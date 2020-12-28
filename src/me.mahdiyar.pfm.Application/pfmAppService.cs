using System;
using System.Collections.Generic;
using System.Text;
using me.mahdiyar.pfm.Localization;
using Volo.Abp.Application.Services;

namespace me.mahdiyar.pfm
{
    /* Inherit your application services from this class.
     */
    public abstract class pfmAppService : ApplicationService
    {
        protected pfmAppService()
        {
            LocalizationResource = typeof(pfmResource);
        }
    }
}

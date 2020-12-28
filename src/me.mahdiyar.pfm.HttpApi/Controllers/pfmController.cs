using me.mahdiyar.pfm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace me.mahdiyar.pfm.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class pfmController : AbpController
    {
        protected pfmController()
        {
            LocalizationResource = typeof(pfmResource);
        }
    }
}
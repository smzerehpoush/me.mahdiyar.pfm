using me.mahdiyar.pfm.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace me.mahdiyar.pfm.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class pfmPageModel : AbpPageModel
    {
        protected pfmPageModel()
        {
            LocalizationResourceType = typeof(pfmResource);
        }
    }
}
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace me.mahdiyar.pfm.Web
{
    [Dependency(ReplaceServices = true)]
    public class pfmBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "pfm";
    }
}

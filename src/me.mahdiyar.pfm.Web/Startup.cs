using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace me.mahdiyar.pfm.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<pfmWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}

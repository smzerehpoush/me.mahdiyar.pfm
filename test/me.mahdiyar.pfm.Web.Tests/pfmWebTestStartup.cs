using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace me.mahdiyar.pfm
{
    public class pfmWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<pfmWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}
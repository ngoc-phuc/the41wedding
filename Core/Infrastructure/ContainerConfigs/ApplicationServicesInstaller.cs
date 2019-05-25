
using Abstractions.Services;
using Common.Runtime.Session;

using EntityFrameworkCore.Audits;
using EntityFrameworkCore.EntityHistory;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Services.Implementations;

namespace Infrastructure.ContainerConfigs
{
    public static class ApplicationServicesInstaller
    {
        public static void ConfigureApplicationServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IBysSession, BysSession>();
            services.AddScoped<IAuditHelper, AuditHelper>();
            services.AddScoped<IEntityHistoryHelper, EntityHistoryHelper>();

            services.AddDataProtection();

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services
                .AddSingleton<IActionContextAccessor, ActionContextAccessor>()
                .AddSingleton(
                    x => x
                        .GetRequiredService<IUrlHelperFactory>()
                        .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext));
        }
    }
}
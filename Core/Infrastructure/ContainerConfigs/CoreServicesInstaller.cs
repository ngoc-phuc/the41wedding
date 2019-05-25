using System.Collections.Generic;
using System.Globalization;

using Common.Configurations;
using EntityFrameworkCore.Contexts;
using EntityFrameworkCore.UnitOfWork;

using Infrastructure.Filters;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.ContainerConfigs
{
    public static class CoreServicesInstaller
    {
        public static void ConfigureCoreServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc(
                options =>
                    options.Filters.Add(typeof(HttpGlobalExceptionFilter))
            );

            services.AddDbContext<ErpDbContext>(
                options =>
                {
                    options.UseSqlServer(
                            configuration["ConnectionStrings:ErpConnection"],
                            b => b.MigrationsAssembly("Bys.EntityFrameworkCore").UseRowNumberForPaging())

                        //.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
                        ;
                });

            services.AddUnitOfWork<ErpDbContext>();

            services.Configure<SmtpConfig>(configuration.GetSection(nameof(SmtpConfig)));
            services.Configure<FileStorageConfig>(configuration.GetSection(nameof(FileStorageConfig)));

            // Register localization
            services.AddLocalization();

            services.AddScoped<ModelValidationFilterAttribute>();

            services.AddMemoryCache();

            services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = new List<CultureInfo>
                    {
                        new CultureInfo("vi-VN"),
                        new CultureInfo("vi"),
                    };

                    options.DefaultRequestCulture = new RequestCulture("en-US");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                });

            // Add cors
            services.AddCors();
        }
    }
}
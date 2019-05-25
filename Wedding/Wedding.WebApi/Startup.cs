using Common.Dependency;
using Infrastructure.ContainerConfigs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Bys.Hbc.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            CoreServicesInstaller.ConfigureCoreServices(services, Configuration);
            AuthServicesInstaller.ConfigureServicesAuth(services, Configuration);
            ApplicationServicesInstaller.ConfigureApplicationServices(services, Configuration);

            ServiceLocator.SetLocatorProvider(services.BuildServiceProvider);

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(
                c =>
                {
                    c.DescribeAllEnumsAsStrings();
                    c.SwaggerDoc(
                        "v1",
                        new Info
                        {
                            Title = "Wedding.PROJECT API",
                            Version = "v1",
                            Description = "ASP.NET Core Web API 2",
                            TermsOfService = "None",
                            Contact = new Contact
                            {
                                Name = "Bui Thi Ngoc Phuc",
                                Email = "ngocphuc2015.np@gmail.com",
                                Url = "ngocphuc2015.np@gmail.com"
                            },
                            License = new License
                            {
                                Name = "Copyright by The 41 Wedding Team",
                                Url = ""
                            }
                        });

                    c.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}");

                    var filePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "Wedding.WebApi.xml");
                    c.IncludeXmlComments(filePath);
                });

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            //app.UseMiddleware<ErrorHandlingMiddleware>();

            // Configure Cors
            app.UseCors(
                builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("Content-Disposition"));

            app.UseAuthentication();

            // Configure localization
            var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("vi"),
            };
            var options = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("vi-VN"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };

            app.UseRequestLocalization(options);

            app.UseStaticFiles();
            //            app.UseStaticFiles(new StaticFileOptions
            //            {
            //                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "Uploads")),
            //                RequestPath = new PathString("/Uploads")
            //            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(
                c =>
                {
                    c.DocumentTitle("The 41 Wedding Team API Document");
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
                });

            app.UseMvc();

            //            app.UseMvc(routes =>
            //            {
            //                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //            });

            app.UseSignalR();

        }
    }
}
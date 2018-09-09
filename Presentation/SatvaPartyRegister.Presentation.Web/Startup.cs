using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using SatvaPartyRegister.Presentation.Web.Helpers;
using SatvaPartyRegister.Presentation.Web.Services;

namespace SatvaPartyRegister.Presentation.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ILifetimeScope ApplicationContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Add Kendo UI services to the services container
            services.AddKendo();

            // create a Autofac container builder
            var builder = new ContainerBuilder();

            // read service collection to Autofac
            builder.Populate(services);

            builder.RegisterType<HttpContextAccessor>()
                .As<IHttpContextAccessor>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ApiClient>()
                .WithParameter(new NamedParameter("basePath", Configuration["BaseApiPath"]))
                .As<ApiClient>()
                .InstancePerLifetimeScope();

            var webServices = typeof(FinancialYearService).Assembly.GetTypes()
                .Where(w => w.Name.EndsWith("Service")).ToArray(); ;

            builder.RegisterTypes(webServices)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterTypes(webServices).AsSelf();

            // build the Autofac container
            ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(this.ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

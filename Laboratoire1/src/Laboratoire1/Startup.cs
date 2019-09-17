using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratoire1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
/**
 * 
 * Yan Ha Routhier-Chevrier
 * 1473192 - laboratoire 1
 * 
 * */
namespace Laboratoire1
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddRouting(options =>
            {
                options.ConstraintMap.Add("messageParam", typeof(UserMessage));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // routage nécessaire pour mon application
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
                    template: "{controller}/{action}/{type?}/{m_message?}",
                    defaults: new { Controller = "Evaluation", action = "Accueil" },
                    constraints: new { type = new StringRouteConstraint(""), m_message = new StringRouteConstraint("") });
                routes.MapRoute(
                    name: "ids",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { Controller = "Evaluation", action = "Accueil" },
                    constraints: new { id = new IntRouteConstraint() });
            });
        }
    }
}

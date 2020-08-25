using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Webgentle.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Calling Middleware #1 \n");
            //    await next();
            //    await context.Response.WriteAsync("After second Middleware calling middleware #1 \n");
            //});


            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Calling Middleware #2 \n");
            //    await next();
            //});


            app.UseRouting();

            //This will execute when URL append with /Sreeni
            app.UseEndpoints(endPoint =>
            {
                endPoint.MapDefaultControllerRoute();
                //endPoint.MapGet("", async context => { await context.Response.WriteAsync(env.EnvironmentName); });
            });

            //app.UseRouting();
        }
    }
}

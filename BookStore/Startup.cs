using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
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

            // we use number of Http application Pipeline called middleware component in an application 

            /* app.Use(async(context, next) =>
             {
                 await context.Response.WriteAsync("Hello from my first Middleware");
                 await next();
                 await context.Response.WriteAsync("Hello my fist middleware response");
             });

             app.Use(async(context, next) =>
             {
               await context.Response.WriteAsync("This is my Second middleware");
             });*/

            app.UseStaticFiles();
           /* app.UseStaticFiles(new StaticFileOptions() // it is used to access static file resite in another folder than wwwroot folder
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Mystaticfiles")),
                RequestPath = "/Mystaticfiles"
            });*/
            app.UseRouting(); // we must declare UseRouting method before use of ENdpopint.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute(); // use of this its use default controller(Home) with default Action Method(index)
               /* endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/
            });

            // we map url with resorces
           /* app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Akash", async context =>
                {
                    await context.Response.WriteAsync("Hello Akash saini!");
                });
            });*/
        }
    }
}

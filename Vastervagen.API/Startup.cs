using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tiste.Feature.JSONPlaceholder;
using Tiste.Feature.JSONPlaceholder.Contracts;
using Vastervagen.Feature.HelloWorld;
using Vastervagen.Feature.HelloWorld.Contracts;

namespace Tiste.API
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
            services.AddHttpClient("jsonplaceholder", c =>
            {
                c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            });

            services.AddScoped<IJSONPlaceholderService, JSONPlaceholderService>();
            services.AddScoped<IHelloWorldService, HelloWorldService>();

            services.AddLogging();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

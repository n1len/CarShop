using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Repository;
using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop
{
    public class Startup
    {
        private readonly IConfigurationRoot configurationRoot;

        public Startup(IHostEnvironment hostEnvironment)
        {
            configurationRoot = new ConfigurationBuilder().SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("dbsetting.json").Build();
        }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<SearchCarViewModel>();
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<ICategoryRepository,CategoryRepository>();
            services.AddDbContext<AppDBContent>(option => option.UseSqlServer(configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStatusCodePages();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            using var scope = app.ApplicationServices.CreateScope();
            AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            DbObjects.Initial(content);
        }
    }
}

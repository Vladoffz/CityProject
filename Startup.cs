using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Web.DAL.Impl;
using Web.DAL.Abstract;
using Web.Entities;
using Web.BL.Abstract;
using Web.BL.Impl;

namespace Web.Site
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
            services.AddControllersWithViews();
            services.AddDbContext<WebContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => { b.MigrationsAssembly("Web"); b.EnableRetryOnFailure(); }));

            services.AddTransient<IResidentRepository, ResidentRepository>();
            services.AddTransient<IFlatRepository, FlatRepository>();
            services.AddTransient<IResidentOfFlatRepository, ResidentOfFlatRepository>();
            services.AddTransient<IBuildingRepository, BuildingRepository>();
            services.AddTransient<IStreetRepository, StreetRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddTransient<IResidentService, ResidentService>();
            services.AddTransient<IFlatService, FlatService>();
            services.AddTransient<IResidentOfFlatService, ResidentOfFlatService>();
            services.AddTransient<IBuildingService, BuildingService>();
            services.AddTransient<IStreetService, StreetService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IValidationService, ValidationService>();
            services.AddTransient<IPopulationService, PopulationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

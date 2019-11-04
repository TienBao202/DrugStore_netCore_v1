using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrugStore.Data.EF;
using DrugStore.Data.Entities;
using DrugStore.Infrastructure;
using AutoMapper;
using DrugStore.Application.Implementation;
using DrugStore.Application.AutoMapper;
using DrugStore.Application.ViewModels;
using DrugStore.Application.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DrugStore.Infrastructure.Interfaces;

namespace DrugStore
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton(Configuration);

            services.AddDbContext<DrugStoreDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                o => o.MigrationsAssembly("DrugStore.Data.EF")));

            services.AddAutoMapper();
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));

            services.AddTransient(typeof(IUnitOfWork), typeof(EFUnitOfWork));
            services.AddTransient(typeof(IRepository<,>), typeof(EFRepository<,>));

            services.AddScoped<IAccount_Service, Account_Service>();
            services.AddScoped<IAgency_Service, Agency_Service>();
            services.AddScoped<ICountry_Service, Country_Service>();
            services.AddScoped<ICustomer_Service, Customer_Service>();
            services.AddScoped<IEmployee_Service, Employee_Service>();
            services.AddScoped<IMedicine_Batch_Service, Medicine_Batch_Service>();
            services.AddScoped<IMedicine_Category_Service, Medicine_Category_Service>();
            services.AddScoped<IMedicine_Unit_Service, Medicine_Unit_Service>();
            services.AddScoped<IMedicine_Service, Medicine_Service>();
            services.AddScoped<IPosition_Service, Position_Service>();
            services.AddScoped<ISupplier_Service, Supplier_Service>();
            services.AddScoped<ISupplier_Group_Service, Supplier_Group_Service>();

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
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

using BLL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Data;
using WebUI.Models;
using Microsoft.AspNetCore.Rewrite;

namespace WebUI
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("IdentityConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddHttpClient<IGoodService, GoodService>(client=>
                client.BaseAddress = new Uri("https://localhost:44359/"));
            services.AddHttpClient<ICategoryService, CategoryService>(client =>
                client.BaseAddress = new Uri("https://localhost:44359/"));
            services.AddHttpClient<IManufacturerService, ManufacturerService>(client =>
                client.BaseAddress = new Uri("https://localhost:44359/"));

            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddScoped<Favorites>(sp => SessionFavorites.GetFavorites(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();


            //TO DO Красивые ЮРЛ понять как делать через реджексы
            //var options = new RewriteOptions()
            //    .AddRedirect("(.*)/$", "$1")
            //    .AddRewrite(@"home/details/(\d+)", "home/details?id=$1", skipRemainingRules: false);
            //app.UseRewriter(options);


            app.UseRouting();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Store}/{id?}");
                endpoints.MapControllerRoute(
                     name: "admin",
                    pattern: "{controller=Admin}/{action=Goods}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

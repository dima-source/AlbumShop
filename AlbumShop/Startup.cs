using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumShop.Data;
using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Mock;
using AlbumShop.Data.Models;
using AlbumShop.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AlbumShop
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationContext>();
            services.AddTransient<IAllAlbums, AlbumRepository>();
            services.AddTransient<IAlbumCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();
            services.AddTransient<IAllStaff, MockStaff>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            services.AddSignalR();
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Chat}/{action=Index}");
            //    endpoints.MapHub<ChatHub>("/chat");
            //});
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Album/{action}/{category?}", defaults: new { Controller = "Album", action = "List" });
                //routes.MapRoute(name: "Staff", template: "Staff/{action}/{category?}", defaults: new { Controller = "Staff", action = "List" });
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                ApplicationContext content = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                DBObjects.Initial(content);
            }

        }
    }
}

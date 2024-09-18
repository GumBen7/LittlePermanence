using LittlePermanence.DebugOnly;
using LittlePermanence.Models;
using Microsoft.EntityFrameworkCore;

namespace LittlePermanence {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<TutoringCenterDbContext>(options => {
                options.UseInMemoryDatabase("TutoringCenterDb");
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();

#if DEBUG
            builder.Services.AddScoped<DataInitializer>();
#endif

            var app = builder.Build();

#if DEBUG
            using (var scope = app.Services.CreateScope()) {
                scope.ServiceProvider.GetRequiredService<DataInitializer>().Initialize();
            }
#endif

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

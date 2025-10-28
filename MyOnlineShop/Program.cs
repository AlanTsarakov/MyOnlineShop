using MyOnlineShop.Interfaces;
using MyOnlineShop.Repositories;

namespace MyOnlineShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<ICartsRepository, InMemoryCartsRepository>();
            builder.Services.AddSingleton<IProductsRepository, InMemoryProductsRepository>();
            builder.Services.AddSingleton<IOrdersRepository, InMemoryOrdersRepository>();
            builder.Services.AddSingleton<IFavoritesRepository, InMemoryFavoritesRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
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
                pattern: "{controller=Home}/{action=Index}/");

            app.Run();
        }
    }
}

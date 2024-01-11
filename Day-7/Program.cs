//using Microsoft.EntityFrameworkCore;
//using Day_7.Data;

//namespace Day_7;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var builder = WebApplication.CreateBuilder(args);

//        // Add services to the container.
//        builder.Services.AddControllersWithViews();

//        // to perform automatic database operations  according to DbContext ( no sql query , no fields etc )
//        // to make use Dbcontext and connection 
//        builder.Services.AddDbContext<Day_7.Data.MyDbContext>(options =>
//        {
//            var connectionString =
//            builder.Configuration.GetConnectionString("MySqlConn");
//            options.UseMySql(connectionString,
//                ServerVersion.AutoDetect(connectionString));
//        });

//        var app = builder.Build();

//        // Configure the HTTP request pipeline.
//        if (!app.Environment.IsDevelopment())
//        {
//            app.UseExceptionHandler("/Home/Error");
//            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//            app.UseHsts();
//        }

//        app.UseHttpsRedirection();
//        app.UseStaticFiles();

//        app.UseRouting();

//        app.UseAuthorization();

//        app.MapControllerRoute(
//            name: "default",
//            pattern: "{controller=Home}/{action=Index}/{id?}");

//        app.Run();
//    }
//}


using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;
using Day_7.Models;
using Day_7.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyDbContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("MySqlConn"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySqlConn"))));

//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<MyDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
//    endpoints.MapRazorPages();

//});

//app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();


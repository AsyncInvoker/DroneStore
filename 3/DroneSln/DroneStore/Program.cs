using DroneStore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:DroneStoreConnection"]);
});
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
//app.MapGet("/", () => "Hello World!");

app.Run();

using BusMonoliticApp.Web.Data.Context;
using BusTicketsMonolitic.Web.Data.DbObjects;
using BusTicketsMonolitic.Web.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BoletosBusContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BoletosBusContext")));

builder.Services.AddScoped<IAsientoDb, AsientoDb>();
builder.Services.AddScoped<IBusDb, BusDb>();
builder.Services.AddScoped<IClienteDb, ClienteDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

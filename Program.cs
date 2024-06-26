using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.BL.Services;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.BL.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BoletosBusContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BoletoBusContext")));
builder.Services.AddScoped<IReservaDb, ReservaDb> ();
builder.Services.AddTransient<IReservaService, ReservaService>();

builder.Services.AddScoped<IReservaDetalleDb, ReservaDetalleDb> ();
builder.Services.AddTransient<IReservaDetalleService, ReservaDetalleService>();

builder.Services.AddScoped<IRutaDb, RutaDb> ();
builder.Services.AddTransient<IRutaService, RutaService>();

builder.Services.AddScoped<IViajeDb, ViajeDb> ();
builder.Services.AddTransient<IViajeService, ViajeService>();

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

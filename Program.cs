using BusMonoliticApp.Web.Data.Context;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.BL.Services;
using BusTicketsMonolitic.Web.Data.DbObjects;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.ServiceCollection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BoletosBusContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BoletosBusContext")));


//Servicios:

builder.Services.AddDataServices();
builder.Services.AddBusinessLogicServices();



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

using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.BL.Services;
using BusTicketsMonolitic.Web.Data.DbObjects;
using BusTicketsMonolitic.Web.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace BusTicketsMonolitic.Web.ServiceCollection
{
    public static class ServicesReferences
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IAsientoDb, AsientoDb>();
            services.AddScoped<IBusDb, BusDb>();
            services.AddScoped<IClienteDb, ClienteDb>();
        }

        public static void AddBusinessLogicServices(this IServiceCollection services)
        {
            services.AddTransient<IAsientoService, AsientoService>();
            services.AddTransient<IBusService, BusService>();
            services.AddTransient<IClienteService, ClienteService>();
        }
    }
}

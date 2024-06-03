using BusMonoliticApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusMonoliticApp.Web.Data.Context
{
    public class BoletosBusContext : DbContext
    {
        #region "Constructor"
        public BoletosBusContext(DbContextOptions<BoletosBusContext> options) : base(options)   
        {
            
        }
        #endregion
        
        #region  "Db Sets"
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle {get; set;}
        public DbSet<Ruta> Ruta {get; set;}
        public DbSet<Viaje> Viaje {get; set;}
        #endregion
    }
}

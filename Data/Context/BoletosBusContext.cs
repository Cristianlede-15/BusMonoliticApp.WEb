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

        #region "Db Sets"
        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        #endregion
    }
}

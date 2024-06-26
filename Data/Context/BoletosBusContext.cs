using BusMonoliticApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BusMonoliticApp.Web.Data.Context
{
    public class BoletosBusContext : DbContext
    {
        #region "Constructor"
        public BoletosBusContext(DbContextOptions<BoletosBusContext> options) :base(options)
        {  
        }
        #endregion

        #region "Db Sets"
        public DbSet<Menu> Menu {get; set;}
        public DbSet<Mesa> Mesa {get; set;}
        public DbSet<Usuario> Usuario {get; set;}

        internal void SaveChanges(Usuario cambio)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

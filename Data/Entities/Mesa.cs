using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Mesa : BaseEntity
    {
        public int? Capacidad { get; set; }
        public string? Estado { get; set; }
    }
}

using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Pedido : BaseEntity
    {
        public int? IdCliente { get; set; }
        public int? IdMesa { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Total { get; set; }
    }
}

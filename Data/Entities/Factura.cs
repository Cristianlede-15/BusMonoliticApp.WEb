using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Factura : BaseEntity
    {
        public int? IdPedido { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Fecha { get; set; }
    }
}

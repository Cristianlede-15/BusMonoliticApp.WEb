using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class DetallePedido : BaseEntity
    {
        public int IdPedido { get; set; }
        public int IdPlato { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Subtotal { get; set; }
    }
}

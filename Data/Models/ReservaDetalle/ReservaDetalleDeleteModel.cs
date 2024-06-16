using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;

namespace BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb
{
    public class ReservaDetalleDeleteModel : ReservaDetalleBaseModel
    {
         public int IdResarvaDetalle { get; set; }
        public int? IdAsiento { get; internal set; }
    }
}

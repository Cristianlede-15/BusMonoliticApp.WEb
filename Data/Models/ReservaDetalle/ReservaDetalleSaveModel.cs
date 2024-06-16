using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;

namespace BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb
{
    public class ReservaDetalleSaveModel : ReservaDetalleBaseModel
    {
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}

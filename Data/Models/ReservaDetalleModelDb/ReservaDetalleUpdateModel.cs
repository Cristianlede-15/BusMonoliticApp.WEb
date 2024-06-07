namespace BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb
{
    public class ReservaDetalleUpdateModel
    {
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}

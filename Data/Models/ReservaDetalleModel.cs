namespace BusMonoliticApp.Web.Data.Models
{
    public class ReservaDetalleModel
    {
        public int IdResarvaDetalles { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
        
    }
}
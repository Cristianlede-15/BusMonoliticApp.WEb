namespace BusTicketsMonolitic.Web.Data.Models
{
    public class ReservaDetalleModelAccess
    {
        public int IdResarvaDetalles { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
namespace BusMonoliticApp.Web.Data.Models.ReservaModelDb
{
    public class ReservaSaveModel
    {

        public int? IdViaje { get; set; }
        public int? IdPasajero { get; set; }
        public int? AsientosReservados { get; set; }
        public decimal? MontoTotal { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}

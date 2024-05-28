

using BusMonoliticApp.Web.Data.Core;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class Reserva : BaseEntity
    {
        public int? IdViaje { get; set; }
        public int? IdPasajero { get; set; }
        public int? AsientosReservados { get; set; }
        public decimal? MontoTotal { get; set; }
    }
}


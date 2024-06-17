

using BusMonoliticApp.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class Reserva : BaseEntity
    {
        public int IdReserva { get; set; }
        [Key]
        public int? IdViaje { get; set; }
        //  IdPasajero tiene que ser eliminado, No esta en la base de datos
        public int? IdPasajero { get; set; }
        public int? AsientosReservados { get; set; }
        public decimal? MontoTotal { get; set; }
    }
}


using BusMonoliticApp.Web.Data.Core;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class ReservaDetalle : BaseEntity
    {
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
    }
}

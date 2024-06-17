using BusMonoliticApp.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class ReservaDetalle : BaseEntity
    {
        public int IdReservaDetalle { get; set; }
        [Key]
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
    }
}

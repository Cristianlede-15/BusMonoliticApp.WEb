
using System.ComponentModel.DataAnnotations;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Asiento
    {
        public int? IdBus { get; set; }
        [Key]
        public int IdAsiento { get; set; }
        public int? NumeroPiso {  get; set; }
        public int? NumeroAsiento { get; set; }

        //public DateTime FechaModificacion { get; set; }
        public DateTime? FechaCreacion { get; internal set; }
    }
}

using BusMonoliticApp.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Mesa : BaseEntity
    {
        [Key]
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public string? Estado { get; set; }
    }
}

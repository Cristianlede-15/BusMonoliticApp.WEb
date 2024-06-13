
using System.ComponentModel.DataAnnotations;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}
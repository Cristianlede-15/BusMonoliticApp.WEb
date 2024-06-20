using BusMonoliticApp.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Menu : BaseEntity
    {
        [Key]
        public int IdPlato { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; }
    }
}

using BusMonoliticApp.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class Ruta : BaseEntity
    {
        public int IdRuta { get; set; }
        [Key]
        public string? Origen { get; set; }
        public string? Destino { get; set; }
    }
}

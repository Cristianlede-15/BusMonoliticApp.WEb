using BusMonoliticApp.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class Ruta : BaseEntity
    {
        [Key]
        public int IdRuta { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
    }
}

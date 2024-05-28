using BusMonoliticApp.Web.Data.Core;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class Ruta : BaseEntity
    {
        public string? Origen { get; set; }
        public string? Destino { get; set; }
    }
}

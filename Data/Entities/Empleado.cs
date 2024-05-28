
using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Empleado : BaseEntity
    {
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
    }
}

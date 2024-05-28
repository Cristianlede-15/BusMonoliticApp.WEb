using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Bus : BaseEntity
    {
        public string? NumeroPlaca {  get; set; }
        public string? Nombre { get; set; }
        public int? CapacidadPiso1 { get; set; }
        public int? CapacidadPiso2 {  get; set; }
        public int? CapacidadTotal => (CapacidadPiso1 ?? 0) + (CapacidadPiso2 ?? 0);
        public bool? Disponible { get; set; }

    }
}

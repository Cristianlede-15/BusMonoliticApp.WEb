using BusTicketsMonolitic.Web.Data.Core;

namespace BusTicketsMonolitic.Web.Data.Entities
{
    public class Bus: BaseEntitiy
    {
        public string NumeroPlaca { get; set; }
        public string Nombre { get; set; }
        public int CapacidadPiso1 { get; set; }
        public int CapacidadPiso2 { get; set; }
        public int CapacidadTotal => CapacidadPiso1 + CapacidadPiso2;
        public bool Disponible { get; set; }
        public ICollection<Asiento> Asientos { get; set; }
    }
}

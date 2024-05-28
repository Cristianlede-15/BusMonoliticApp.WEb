
using BusTicketsMonolitic.Web.Data.Core;

namespace BusTicketsMonolitic.Web.Data.Entities
{ 
    public class Asiento : BaseEntitiy
    {
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        // Relación con la entidad Bus (si es necesario, dependiendo de tu ORM)
        public Bus Bus { get; set; }

    }
}

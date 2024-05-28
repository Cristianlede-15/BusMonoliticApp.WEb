using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Asiento : BaseEntity
    {
        public int? IdBus {  get; set; }
        public int? NumeroPiso {  get; set; }
        public int? NumeroAsiento { get; set; }

    }
}

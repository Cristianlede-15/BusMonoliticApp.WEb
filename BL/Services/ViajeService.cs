using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.Viaje;

namespace BusMonoliticApp.Web.BL.Services
{
    public class ViajeService : IViajeService
    {
        private IViajeDb viajeDb;
        public ViajeService(IViajeDb viajeDb)
        {
            this.viajeDb = viajeDb;
        }
        public List<ViajeModelAccess> GetViaje()
        {
            return this.viajeDb.GetViaje();
        }
    }
}
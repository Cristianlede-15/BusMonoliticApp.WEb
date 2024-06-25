using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.Ruta;
using BusTicketsMonolitic.Web.BL.Interfaces;

namespace BusMonoliticApp.Web.BL.Services
{
    public class RutaService : IRutaService
    {
        private readonly IRutaDb rutaDb;

        public RutaService(IRutaDb rutaDb)
        {
            this.rutaDb = rutaDb;
        }
        public List<RutaModelAccess> GetRutas()
        {
            return this.rutaDb.GetRutas();
        }
    }
}

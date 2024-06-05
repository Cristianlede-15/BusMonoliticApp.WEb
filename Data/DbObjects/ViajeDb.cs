using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ViajeModelDb;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class ViajeDb : IViajeDb
    {
        private readonly BoletosBusContext context;

        public ViajeDb(BoletosBusContext context)
        {
            this.context = context;
        }
        public void DeleteViaje(ViajeDeleteModel viajeDeleteModel)
        {
            throw new NotImplementedException();
        }

        public List<ViajeModelAccess> GetViaje()
        {
            throw new NotImplementedException();
        }

        public ViajeModelAccess GetViaje(int IdViaje)
        {
            throw new NotImplementedException();
        }

        public void SaveViaje(ViajeSaveModel viajeSaveModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateViaje(ViajeUpdateModel viajeUpdateModel)
        {
            throw new NotImplementedException();
        }
    }
}
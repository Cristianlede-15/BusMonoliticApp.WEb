using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.RutaModelDB;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class RutaDb : IRutaDb
    {
        private readonly BoletosBusContext context;

        public RutaDb(BoletosBusContext context)
        {
            this.context = context;
        }
        public void DeleteRuta(RutaDeleteModel deleteModel)
        {
            throw new NotImplementedException();
        }

        public List<RutaModelAccess> GetRutas()
        {
            throw new NotImplementedException();
        }

        public RutaModelAccess GetRutas(int idRuta)
        {
            throw new NotImplementedException();
        }

        public void SaveRuta(RutaSaveModel saveModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateRuta(RutaUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
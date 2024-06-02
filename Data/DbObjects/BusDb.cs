using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class BusDb : IBusDb
    {
        private readonly BoletosBusContext context;

        public BusDb(BoletosBusContext context)
        {
            this.context = context;
        }
        public void DeleteBus(BusDeleteModel busDeleteModel)
        {
            throw new NotImplementedException();
        }

        public List<BusModelsAccess> GetBus()
        {
            throw new NotImplementedException();
        }

        public BusModelsAccess GetBus(int IdBus)
        {
            throw new NotImplementedException();
        }

        public void SaveBus(BusSaveModel busSaveModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateBus(BusUpdateModel busUpdateModel)
        {
            throw new NotImplementedException();
        }
    }
}

using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;

namespace BusTicketsMonolitic.Web.Data.Interfaces
{
    public interface IBusDb
    {
        void SaveBus(BusSaveModel busSaveModel);
        void DeleteBus(BusDeleteModel busDeleteModel);
        void UpdateBus(BusUpdateModel busUpdateModel);

        List<BusModelsAccess> GetBus();
        BusModelsAccess GetBus(int IdBus);
    }
}

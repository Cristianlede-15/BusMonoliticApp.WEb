using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;

namespace BusTicketsMonolitic.Web.Data.Interfaces
{
    public interface IAsientoDb
    {
        void SaveAsiento(AsientoSaveModel asientoSaveModel);
        void UpdateAsiento(AsientoUpdateModel asientoUpdateModel);
        void DeleteAsiento(AsientoDeleteModel asientoDeleteModel);

        List<AsientoModelsAccess> GetAsientos();
        AsientoModelsAccess GetAsientos(int IdAsiento);
    }
}

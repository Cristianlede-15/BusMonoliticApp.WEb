using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ViajeModelDb;

namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IViajeDb
    {
        void SaveViaje(ViajeSaveModel viajeSaveModel);
        void UpdateViaje(ViajeUpdateModel viajeUpdateModel);
        void DeleteViaje(ViajeDeleteModel viajeDeleteModel);

        List<ViajeModelAccess> GetViaje();
        ViajeModelAccess GetViaje(int IdViaje);
    }
}
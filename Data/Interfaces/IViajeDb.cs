using BusMonoliticApp.Web.Data.Models.ViajeModelDb;
using BusTicketsMonolitic.Web.Data.Models.Viaje;


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
using BusMonoliticApp.Web.Data.Models.ViajeModelDb;
using BusTicketsMonolitic.Web.Data.Models.Viaje;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IViajeDb
    {
        void SaveViaje(ViajeSaveModel ViajeSaveModel);
        void UpdateViaje(ViajeUpdateModel ViajeUpdateModel);
        void DeleteViaje(ViajeDeleteModel ViajeDeleteModel);

        List<ViajeModelAccess> GetViaje();
        ViajeModelAccess GetViaje(int IdViaje);
    }
}
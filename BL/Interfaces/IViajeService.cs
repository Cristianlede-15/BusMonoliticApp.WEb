using BusMonoliticApp.Web.Data.Models.ReservaModelDb;
using BusMonoliticApp.Web.Data.Models.ViajeModelDb;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.Data.Models.Viaje;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IViajeService
    {
        ServiceResult GetViaje();
        ServiceResult GetViaje(int id);
        ServiceResult UpDateViaje(ViajeUpdateModel viajeUpdateModel);
        ServiceResult DeleteReservas(ViajeDeleteModel viajeDeleteModel);
        ServiceResult SaveViaje(ViajeSaveModel viajeSaveModel);
    }
}

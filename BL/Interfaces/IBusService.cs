using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IBusService
    {
        ServiceResult GetBuses();
        ServiceResult GetBus(int id);
        ServiceResult UpdateBuses(BusUpdateModel busUpdate);
        ServiceResult DeleteBus(BusDeleteModel busDelete);
        ServiceResult SaveBus(BusSaveModel busSave);
    }
}

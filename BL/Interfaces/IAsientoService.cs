using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IAsientoService
    {
        ServiceResult GetAsientos();
        ServiceResult GetAsiento(int id);
        ServiceResult UpdateAsientos(AsientoUpdateModel asientoUpdate);
        ServiceResult DeleteAsientos(AsientoDeleteModel asientoDelete);
        ServiceResult SaveAsiento(AsientoSaveModel asientoSave);
    }
}

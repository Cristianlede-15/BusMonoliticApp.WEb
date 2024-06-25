using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IReservaDetalleService
    {
        ServiceResult GetReservaDetalles();
        ServiceResult GetReservaDetalles(int id);
        ServiceResult UpdateReservaDetalles(ReservaDetalleUpdateModel reservaDetalleUpdateModel);
        ServiceResult DeleteReservaDetalles(ReservaDetalleDeleteModel reservaDetalleDeleteModel);
        ServiceResult SaveReservaDetalles(ReservaDetalleSaveModel reservaDetalleSaveModel);
    }
}

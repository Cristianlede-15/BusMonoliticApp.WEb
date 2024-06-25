using BusMonoliticApp.Web.Data.Models.ReservaModelDb;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;

namespace BusMonoliticApp.Web.BL.Core
{
    public interface IReservaService
    {
        ServiceResult GetReservas();
        ServiceResult GetReservas(int id);
        ServiceResult UpdateReservas(ReservaSaveModel reservaSaveModel);
        ServiceResult DeleteReservas(ReservaDeleteModel reservaDeleteModel);
        ServiceResult SaveReserva(ReservaSaveModel reservaSaveModel);
    }
}

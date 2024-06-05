using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;

namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IReservaDb
    {
        void SaveReserva(ReservaSaveModel ReservaSaveModel);
        void UpdaterReserva(ReservaUpdateModel ReservaUpdateModel);
        void DeleteReserva (ReservaDeleteModel ReservaDeleteModel);

        List<ReservaModelAccess> GetReserva();
        ReservaModelAccess GetReserva(int IdReserva);
    }
}

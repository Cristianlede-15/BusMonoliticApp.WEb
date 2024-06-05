using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalleModelDb;

namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IReservaDetalleDb
    {
        void SaveReservaDetalle(ReservaDetalleDeleteModel reservaDetalleDeleteModel);
        void UpdateReservaDetalle(ReservaDetalleUpdateModel reservaDetalleUpdateModel);
        void DeleteReservaDetalle(ReservaDetalleDeleteModel reservaDetalleDeleteModel);

        List<ReservaDetalleModelAccess> GetReservasDetalles();
        ReservaDetalleModelAccess GetReservaDetalle (int idReserva);
    }
}

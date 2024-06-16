using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IReservaDetalleDb
    {
        void SaveReservaDetalle(ReservaDetalleSaveModel reservaDetalleSaveModel);
        void UpdateReservaDetalle(ReservaDetalleUpdateModel reservaDetalleUpdateModel);
        void DeleteReservaDetalle(ReservaDetalleDeleteModel reservaDetalleDeleteModel);

        List<ReservaDetalleModelAccess> GetReservasDetalles();
        ReservaDetalleModelAccess GetReservaDetalle (int IdResarvaDetalle);
    }
}

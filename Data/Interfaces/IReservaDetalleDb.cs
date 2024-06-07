using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;


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

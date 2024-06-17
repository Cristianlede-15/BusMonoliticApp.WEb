using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IReservaDetalleDb
    {
        void SaveReservaDetalle(ReservaDetalleSaveModel ReservaDetalleSaveModel);
        void UpdateReservaDetalle(ReservaDetalleUpdateModel ReservaDetalleUpdateModel);
        void DeleteReservaDetalle(ReservaDetalleDeleteModel ReservaDetalleDeleteModel);

        List<ReservaDetalleModelAccess> GetReservaDetalle();
        ReservaDetalleModelAccess GetReservaDetalle (int IdResarvaDetalle);
    }
}

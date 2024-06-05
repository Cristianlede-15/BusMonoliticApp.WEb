using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalleModelDb;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class ReservaDetalleDb : IReservaDetalleDb
    {
        private readonly BoletosBusContext context;

        public ReservaDetalleDb(BoletosBusContext context)
        {
            this.context = context;
        }
        public void DeleteReservaDetalle(ReservaDetalleDeleteModel reservaDetalleDeleteModel)
        {
            throw new NotImplementedException();
        }

        public ReservaDetalleModelAccess GetReservaDetalle(int idReserva)
        {
            throw new NotImplementedException();
        }

        public List<ReservaDetalleModelAccess> GetReservasDetalles()
        {
            throw new NotImplementedException();
        }

        public void SaveReservaDetalle(ReservaDetalleDeleteModel reservaDetalleDeleteModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateReservaDetalle(ReservaDetalleUpdateModel reservaDetalleUpdateModel)
        {
            throw new NotImplementedException();
        }
    }
}
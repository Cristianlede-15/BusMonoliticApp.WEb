using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class ReservaDb : IReservaDb
    {
        private readonly BoletosBusContext context;

        public ReservaDb(BoletosBusContext context)
        {
            this.context = context;
        }
        void IReservaDb.DeleteReserva(ReservaDeleteModel ReservaDeleteModel)
        {
            throw new NotImplementedException();
        }

        List<ReservaModelAccess> IReservaDb.GetReserva()
        {
            throw new NotImplementedException();
        }

        ReservaModelAccess IReservaDb.GetReserva(int IdReserva)
        {
            throw new NotImplementedException();
        }

        void IReservaDb.SaveReserva(ReservaSaveModel ReservaSaveModel)
        {
            throw new NotImplementedException();
        }

        void IReservaDb.UpdaterReserva(ReservaUpdateModel ReservaUpdateModel)
        {
            throw new NotImplementedException();
        }
    }
}

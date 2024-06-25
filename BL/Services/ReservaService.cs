using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;

namespace BusMonoliticApp.Web.BL.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaDb reservaDb;
        public ReservaService(IReservaDb reservaDb)
        {
            this.reservaDb = reservaDb;
        }
        public List<ReservaModelAccess> GetReservas()
        {
            return this.reservaDb.GetReserva();
        }
    }
}

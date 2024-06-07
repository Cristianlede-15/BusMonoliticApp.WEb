using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.Web.Data.Models.ReservaModelDb;


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
            var reserva = context.Reserva.Find(ReservaDeleteModel.IdReserva);
            if (reserva != null)
            {
                context.Reserva.Remove(reserva);
                context.SaveChanges();
            }
        }

        List<ReservaModelAccess> IReservaDb.GetReserva()
        {
            return context.Reserva
                          .Select(r => new ReservaModelAccess
                          {
                              IdReserva = r.Id,
                              IdViaje = r.IdViaje,
                              IdPasajero = r.IdPasajero,
                              AsientosReservados = r.AsientosReservados,
                              MontoTotal = r.MontoTotal,
                              FechaCreacion = r.FechaCreacion
                          }).ToList();
        }

        ReservaModelAccess IReservaDb.GetReserva(int IdReserva)
        {
            var reserva = context.Reserva.Find(IdReserva);
            if (reserva != null)
            {
                return new ReservaModelAccess
                {
                    IdReserva = reserva.Id,
                    IdViaje = reserva.IdViaje,
                    IdPasajero = reserva.IdPasajero,
                    AsientosReservados = reserva.AsientosReservados,
                    MontoTotal = reserva.MontoTotal,
                    FechaCreacion = reserva.FechaCreacion
                };
            }
             return null!;    
        }

        void IReservaDb.SaveReserva(ReservaSaveModel ReservaSaveModel)
        {
            var reserva = new Reserva
            {
                IdViaje = ReservaSaveModel.IdViaje,
                IdPasajero = ReservaSaveModel.IdPasajero,
                AsientosReservados = ReservaSaveModel.AsientosReservados,
                MontoTotal = ReservaSaveModel.MontoTotal,
                FechaCreacion = ReservaSaveModel.FechaCreacion ?? DateTime.Now
            };

            context.Reserva.Add(reserva);
            context.SaveChanges();
        }

        void IReservaDb.UpdaterReserva(ReservaUpdateModel ReservaUpdateModel)
        {
            var reserva = context.Reserva.Find(ReservaUpdateModel.IdReserva);
            if (reserva != null)
            {
                reserva.IdViaje = ReservaUpdateModel.IdViaje;
                reserva.IdPasajero = ReservaUpdateModel.IdPasajero;
                reserva.AsientosReservados = ReservaUpdateModel.AsientosReservados;
                reserva.MontoTotal = ReservaUpdateModel.MontoTotal;
                reserva.FechaCreacion = ReservaUpdateModel.FechaCreacion ?? reserva.FechaCreacion;

                context.Reserva.Update(reserva);
                context.SaveChanges();
            }
        }
    }
}

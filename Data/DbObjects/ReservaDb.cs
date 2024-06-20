using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Exceptions;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using BusMonoliticApp.Web.Data.Models.ReservaModelDb;
using BusTicketsMonolitic.Web.Data.Models.Reserva;
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

        public List<ReservaModelAccess> GetReserva()
        {
            return this.context.Reserva.Select(r => new ReservaModelAccess()
            {
                IdReserva = r.IdReserva,
                IdViaje = r.IdViaje,
                IdPasajero = r.IdPasajero,
                AsientosReservados = r.AsientosReservados,
                MontoTotal = r.MontoTotal,
                FechaCreacion = r.FechaCreacion

            }).ToList();
        }

        public ReservaModelAccess GetReserva(int IdReserva)
        {
            var Reserva = this.context.Reserva.Find(IdReserva);
            if (Reserva == null)
            {
                throw new ReservaDbException($"No se encontro reserva");
            }
            ReservaModelAccess reserva = new ReservaModelAccess()
            {
                IdReserva = Reserva.IdReserva,
                IdViaje = Reserva.IdViaje,
                IdPasajero = Reserva.IdPasajero,
                AsientosReservados = Reserva.AsientosReservados,
                MontoTotal = Reserva.MontoTotal,
                FechaCreacion = Reserva.FechaCreacion

            };
            return reserva;
        }

        public void SaveReserva(ReservaSaveModel ReservaSaveModel)
        {
            try
            { 
            Reserva reserva = new Reserva() 
            {
                IdViaje = ReservaSaveModel.IdViaje,
                IdPasajero = ReservaSaveModel.IdPasajero,
                AsientosReservados = ReservaSaveModel.AsientosReservados,
                MontoTotal = ReservaSaveModel.MontoTotal,
                FechaCreacion = ReservaSaveModel.FechaCreacion ?? DateTime.Now
            };
            this.context.Reserva.Add(reserva);
            this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the error or throw
                throw new Exception("Error saving reservation", ex);
            }
        }

        public void UpdaterReserva(ReservaUpdateModel ReservaUpdateModel)
        {
            Reserva reservaUpadate = this.context.Reserva.Find(ReservaUpdateModel.IdReserva);
            reservaUpadate.IdReserva = ReservaUpdateModel.IdReserva;
            reservaUpadate.IdViaje = ReservaUpdateModel.IdViaje;
            reservaUpadate.IdPasajero = ReservaUpdateModel.IdPasajero;
            reservaUpadate.MontoTotal = ReservaUpdateModel.MontoTotal;
            reservaUpadate.AsientosReservados = ReservaUpdateModel.AsientosReservados;
            reservaUpadate.FechaCreacion = ReservaUpdateModel.FechaCreacion;

            this.context.Reserva.Update(reservaUpadate);
            this.context.SaveChanges();
        }
        public void DeleteReserva(ReservaDeleteModel ReservaDeleteModel)
        {
            var reserva = context.Reserva.FirstOrDefault(r => r.IdReserva == ReservaDeleteModel.IdReserva);

            if (reserva != null)
            {
                context.Reserva.Remove(reserva);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Los detalle de esta reserva no existe.");
            }
        }
    }
}

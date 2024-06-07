using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using Microsoft.EntityFrameworkCore;

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
            var reservaDetalle = context.ReservaDetalle.Find(reservaDetalleDeleteModel.IdResarvaDetalle);
            if (reservaDetalle != null)
            {
                context.ReservaDetalle.Remove(reservaDetalle);
                context.SaveChanges();
            }
        }

        public ReservaDetalleModelAccess GetReservaDetalle(int idReservaDetalle)
        {
            var reservaDetalle = context.ReservaDetalle.Find(idReservaDetalle);
            if (reservaDetalle != null)
            {
                return new ReservaDetalleModelAccess
                {
                    IdResarvaDetalle = reservaDetalle.Id,
                    IdReserva = reservaDetalle.IdReserva,
                    IdAsiento = reservaDetalle.IdAsiento,
                    FechaCreacion = reservaDetalle.FechaCreacion
                };
            }
            return null!;
            
        }

        public List<ReservaDetalleModelAccess> GetReservasDetalles()
        {
            return context.ReservaDetalle
                          .Select(rd => new ReservaDetalleModelAccess
                          {
                              IdResarvaDetalle = rd.Id,
                              IdReserva = rd.IdReserva,
                              IdAsiento = rd.IdAsiento,
                              FechaCreacion = rd.FechaCreacion
                          }).ToList();
        }

        public void SaveReservaDetalle(ReservaDetalleSaveModel reservaDetalleSaveModel)
        {
            var reservaDetalle = new ReservaDetalle
            {
                IdReserva = reservaDetalleSaveModel.IdReserva,
                IdAsiento = reservaDetalleSaveModel.IdAsiento,
                FechaCreacion = reservaDetalleSaveModel.FechaCreacion ?? DateTime.Now
            };

            context.ReservaDetalle.Add(reservaDetalle);
            context.SaveChanges();
        }

        public void UpdateReservaDetalle(ReservaDetalleUpdateModel reservaDetalleUpdateModel)
        {
            var reservaDetalle = context.ReservaDetalle.Find(reservaDetalleUpdateModel.IdReservaDetalle);
            if (reservaDetalle != null)
            {
                reservaDetalle.IdReserva = reservaDetalleUpdateModel.IdReserva;
                reservaDetalle.IdAsiento = reservaDetalleUpdateModel.IdAsiento;
                reservaDetalle.FechaCreacion = reservaDetalleUpdateModel.FechaCreacion ?? reservaDetalle.FechaCreacion;

                context.ReservaDetalle.Update(reservaDetalle);
                context.SaveChanges();
           }    
        }
    }
}
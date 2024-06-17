using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;
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

        public List<ReservaDetalleModelAccess> GetReservaDetalle()
        {
            return this.context.ReservaDetalle.Select(rd => new ReservaDetalleModelAccess()
            { 
                IdResarvaDetalle = rd.IdReservaDetalle,
                IdReserva = rd.IdReserva,
                IdAsiento = rd.IdAsiento,
                FechaCreacion = rd.FechaCreacion,
            } ).ToList();
        }

        public ReservaDetalleModelAccess GetReservaDetalle(int IdResarvaDetalle)
        {
            var ReservaDetalle = this.context.ReservaDetalle.Find(IdResarvaDetalle);
            ReservaDetalleModelAccess reservaDetalle = new ReservaDetalleModelAccess()
            {
                IdResarvaDetalle = ReservaDetalle.IdReservaDetalle,
                IdReserva = ReservaDetalle.IdReserva,
                IdAsiento = ReservaDetalle.IdAsiento,
                FechaCreacion = ReservaDetalle.FechaCreacion
            };
            return reservaDetalle;
            
        }

        public void SaveReservaDetalle(ReservaDetalleSaveModel ReservaDetalleSaveModel)
        {
            ReservaDetalle reservaDetalle = new ReservaDetalle()
            {
                
                IdReserva = ReservaDetalleSaveModel.IdReserva,
                IdAsiento = ReservaDetalleSaveModel.IdAsiento,
                FechaCreacion = ReservaDetalleSaveModel.FechaCreacion,
            };
            this.context.ReservaDetalle.Add( reservaDetalle );
            this.context.SaveChanges();
        }

        public void UpdateReservaDetalle(ReservaDetalleUpdateModel ReservaDetalleUpdateModel)
        {
            ReservaDetalle reservaDetalleUpdate = this.context.ReservaDetalle.Find(ReservaDetalleUpdateModel.IdReservaDetalle);
            reservaDetalleUpdate.IdReservaDetalle = ReservaDetalleUpdateModel.IdReservaDetalle;
            reservaDetalleUpdate.IdReserva = ReservaDetalleUpdateModel.IdReserva;
            reservaDetalleUpdate.IdAsiento = ReservaDetalleUpdateModel.IdAsiento;
            reservaDetalleUpdate.FechaCreacion = ReservaDetalleUpdateModel.FechaCreacion;
            this.context.ReservaDetalle.Update( reservaDetalleUpdate );
            this.context.SaveChanges();
        }
        public void DeleteReservaDetalle(ReservaDetalleDeleteModel ReservaDetalleDeleteModel)
        {
            throw new NotImplementedException();
        }
    }
}
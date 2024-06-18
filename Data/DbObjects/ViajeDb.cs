using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ViajeModelDb;
using BusTicketsMonolitic.Web.Data.Models.Viaje;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class ViajeDb : IViajeDb
    {
        private readonly BoletosBusContext context;

        public ViajeDb(BoletosBusContext context)
        {
            this.context = context;
        }

        public List<ViajeModelAccess> GetViaje()
        {
            return this.context.Viaje.Select(v => new ViajeModelAccess()
            {
                IdViaje = v.IdViaje,
                IdBus = v.IdBus,
                IdRuta = v.IdRuta,
                FechaSalida = v.FechaSalida,
                HoraSalida = v.HoraSalida,
                FechaLlegada = v.FechaLlegada,
                HoraLlegada = v.HoraLlegada,
                Precio = v.Precio,
                TotalAsientos = v.TotalAsientos,
                AsientosReservados = v.AsientosReservados,
                FechaCreacion = v.FechaCreacion,

            }).ToList();
             
        }

        public ViajeModelAccess GetViaje(int IdViaje)
        {
            var Viaje = this.context.Viaje.Find(IdViaje);
            ViajeModelAccess viaje = new ViajeModelAccess()
            {
                IdViaje = Viaje.IdViaje,
                IdBus = Viaje.IdBus,
                IdRuta = Viaje.IdRuta,
                FechaSalida = Viaje.FechaSalida,
                HoraSalida = Viaje.HoraSalida,
                FechaLlegada = Viaje.FechaLlegada,
                HoraLlegada = Viaje.HoraLlegada,
                Precio = Viaje.Precio,
                TotalAsientos = Viaje.TotalAsientos,
                AsientosReservados = Viaje.AsientosReservados,
                FechaCreacion = Viaje.FechaCreacion,
            };
             return viaje;
        }

        public void SaveViaje(ViajeSaveModel ViajeSaveModel)
        {
            Viaje viaje = new Viaje()
            {
                IdBus = ViajeSaveModel.IdBus,
                IdRuta = ViajeSaveModel.IdRuta,
                FechaSalida = ViajeSaveModel.FechaSalida,
                HoraSalida = ViajeSaveModel.HoraSalida,
                FechaLlegada = ViajeSaveModel.FechaLlegada,
                HoraLlegada = ViajeSaveModel.HoraLlegada,
                Precio = ViajeSaveModel.Precio,
                TotalAsientos = ViajeSaveModel.TotalAsientos,
                AsientosReservados = ViajeSaveModel.AsientosReservados,
                FechaCreacion = ViajeSaveModel.FechaCreacion,
            };
            this.context.Viaje.Add(viaje);
            this.context.SaveChanges();
        }

        public void UpdateViaje(ViajeUpdateModel ViajeUpdateModel)
        {
            Viaje viajeUpdate = this.context.Viaje.Find(ViajeUpdateModel.IdViaje);
            ViajeUpdateModel.IdViaje = ViajeUpdateModel.IdViaje;
            ViajeUpdateModel.IdBus = ViajeUpdateModel.IdBus;
            ViajeUpdateModel.IdRuta = ViajeUpdateModel.IdRuta;
            ViajeUpdateModel.FechaSalida = ViajeUpdateModel.FechaSalida;
            ViajeUpdateModel.HoraSalida = ViajeUpdateModel.HoraSalida;
            ViajeUpdateModel.FechaLlegada = ViajeUpdateModel.FechaSalida;
            ViajeUpdateModel.HoraLlegada = ViajeUpdateModel.HoraLlegada;
            ViajeUpdateModel.Precio = ViajeUpdateModel.Precio;
            ViajeUpdateModel.TotalAsientos = ViajeUpdateModel.TotalAsientos;
            ViajeUpdateModel.AsientosReservados = ViajeUpdateModel.AsientosReservados;
            ViajeUpdateModel.FechaSalida = ViajeUpdateModel.FechaSalida;
            this.context.Viaje.Update(viajeUpdate);
            this.context.SaveChanges();

        }
        //No se si esta bien
        public void DeleteViaje(ViajeDeleteModel ViajeDeleteModel)
        {
            var viaje = context.Viaje.FirstOrDefault(v => v.IdViaje == ViajeDeleteModel.IdViaje);

            if (viaje != null)
            {
                context.Viaje.Remove(viaje);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("El viaje especificado no existe.");
            }
        }
    }
}
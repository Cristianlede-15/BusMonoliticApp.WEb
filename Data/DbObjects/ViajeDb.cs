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
        public void DeleteViaje(ViajeDeleteModel viajeDeleteModel)
        {
            var viaje = context.Viaje.FirstOrDefault(v => v.IdViaje == viajeDeleteModel.IdViaje);

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

        public List<ViajeModelAccess> GetViaje()
        {
            var viajesEntities = context.Viaje.ToList();
            var viajesModelAccess = viajesEntities.Select(viajeEntity => new ViajeModelAccess
            {
                IdViaje = viajeEntity.IdViaje,
                IdBus = viajeEntity.IdBus,
                IdRuta = viajeEntity.IdRuta,
                FechaSalida = viajeEntity.FechaSalida,
                HoraSalida = viajeEntity.HoraSalida,
                FechaLlegada = viajeEntity.FechaLlegada,
                HoraLlegada = viajeEntity.HoraLlegada,
                Precio = viajeEntity.Precio,
                TotalAsientos = viajeEntity.TotalAsientos,
                AsientosReservados = viajeEntity.AsientosReservados
            }).ToList();

            return viajesModelAccess;
        }

        public ViajeModelAccess GetViaje(int IdViaje)
        {
            var viajeEntity = context.Viaje.FirstOrDefault(v => v.IdViaje == IdViaje);

            if (viajeEntity != null)
            {
                return new ViajeModelAccess
                {
                    IdViaje = viajeEntity.IdViaje,
                    IdBus = viajeEntity.IdBus,
                    IdRuta = viajeEntity.IdRuta,
                    FechaSalida = viajeEntity.FechaSalida,
                    HoraSalida = viajeEntity.HoraSalida,
                    FechaLlegada = viajeEntity.FechaLlegada,
                    HoraLlegada = viajeEntity.HoraLlegada,
                    Precio = viajeEntity.Precio,
                    TotalAsientos = viajeEntity.TotalAsientos,
                    AsientosReservados = viajeEntity.AsientosReservados
                };
            }

            return null!;
        }

        public void SaveViaje(ViajeSaveModel viajeSaveModel)
        {
            var viaje = new Viaje
            {
                IdBus = viajeSaveModel.IdBus,
                IdRuta = viajeSaveModel.IdRuta,
                FechaSalida = viajeSaveModel.FechaSalida,
                HoraSalida = viajeSaveModel.HoraSalida,
                FechaLlegada = viajeSaveModel.FechaLlegada,
                HoraLlegada = viajeSaveModel.HoraLlegada,
                Precio = viajeSaveModel.Precio,
                TotalAsientos = viajeSaveModel.TotalAsientos,
                AsientosReservados = viajeSaveModel.AsientosReservados,
                FechaCreacion = viajeSaveModel.FechaCreacion ?? DateTime.Now
            };

            context.Viaje.Add(viaje);
            context.SaveChanges();
        }

        public void UpdateViaje(ViajeUpdateModel viajeUpdateModel)
        {
            var viaje = context.Viaje.FirstOrDefault(v => v.IdViaje == viajeUpdateModel.IdViaje);

            if (viaje != null)
            {
                viaje.IdBus = viajeUpdateModel.IdBus;
                viaje.IdRuta = viajeUpdateModel.IdRuta;
                viaje.FechaSalida = viajeUpdateModel.FechaSalida;
                viaje.HoraSalida = viajeUpdateModel.HoraSalida;
                viaje.FechaLlegada = viajeUpdateModel.FechaLlegada;
                viaje.HoraLlegada = viajeUpdateModel.HoraLlegada;
                viaje.Precio = viajeUpdateModel.Precio;
                viaje.TotalAsientos = viajeUpdateModel.TotalAsientos;
                viaje.AsientosReservados = viajeUpdateModel.AsientosReservados;
                viaje.FechaCreacion = viajeUpdateModel.FechaCreacion ?? viaje.FechaCreacion;

                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("El viaje especificado no existe.");
            }
        }
    }
}
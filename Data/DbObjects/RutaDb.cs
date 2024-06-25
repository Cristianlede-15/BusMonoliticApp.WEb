using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaModelDb;
using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using BusMonoliticApp.Web.Data.Models.ViajeModelDb;
using BusMonoliticApp.Web.Data.Models.Ruta;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class RutaDb : IRutaDb
    {
        private readonly BoletosBusContext context;

        public RutaDb(BoletosBusContext context)
        {
            this.context = context;
        }

        public List<RutaModelAccess> GetRutas()
        {
            return this.context.Ruta.Select(ru => new RutaModelAccess()
            {
                IdRuta = ru.IdRuta,
                Origen = ru.Origen,
                Destino = ru.Destino,
                FechaCreacion = ru.FechaCreacion,
            }).ToList();
        }

        public RutaModelAccess GetRutas(int IdRuta)
        {
            var Ruta = this.context.Ruta.Find(IdRuta);
            RutaModelAccess ruta = new RutaModelAccess()
            {
                IdRuta = Ruta.IdRuta,
                Origen = Ruta.Origen,
                Destino = Ruta.Destino,
                FechaCreacion = Ruta.FechaCreacion,
            };
            return ruta;
        }

        public void SaveRuta(RutaSaveModel RutaSaveModel)
        {
            Ruta ruta = new Ruta()
            {
                
                Origen = RutaSaveModel.Origen,
                Destino = RutaSaveModel.Destino,
                FechaCreacion = RutaSaveModel.FechaCreacion,
            };
            this.context.Ruta.Add(ruta);
            this.context.SaveChanges();
        }

        public void UpdateRuta(RutaUpdateModel RutaUpdateModel)
        {
            Ruta rutaUpdate = this.context.Ruta.Find(RutaUpdateModel.IdRuta);
            rutaUpdate.IdRuta = RutaUpdateModel.IdRuta;
            rutaUpdate.Origen = RutaUpdateModel.Origen;
            rutaUpdate.Destino = RutaUpdateModel.Destino;
            rutaUpdate.FechaCreacion = RutaUpdateModel.FechaCreacion;
            this.context.Ruta.Update(rutaUpdate);
            this.context.SaveChanges();

        }
        public void DeleteRuta(RutaDeleteModel RutaDeleteModel)
        {
            var ruta = context.Ruta.FirstOrDefault(r => r.IdRuta == RutaDeleteModel.IdRuta);

            if (ruta != null)
            {
                context.Ruta.Remove(ruta);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("La ruta especificada no existe.");
            }
        }
    }
}
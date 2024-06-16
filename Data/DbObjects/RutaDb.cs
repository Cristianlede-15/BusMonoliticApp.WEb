using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using BusTicketsMonolitic.Web.Data.Models.Ruta;


namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class RutaDb : IRutaDb
    {
        private readonly BoletosBusContext context;

        public RutaDb(BoletosBusContext context)
        {
            this.context = context;
        }
        public void DeleteRuta(RutaDeleteModel deleteModel)
        {
            throw new NotImplementedException();
        }

        public List<RutaModelAccess> GetRutas()
        {
            var rutasEntities = context.Ruta.ToList();
            var rutasModelAccess = rutasEntities.Select(rutaEntity => new RutaModelAccess
            {
                Origen = rutaEntity.Origen,
                Destino = rutaEntity.Destino,
                FechaCreacion = rutaEntity.FechaCreacion
            }).ToList();

            return rutasModelAccess;
            
        }

        public RutaModelAccess GetRutas(int IdRuta)
        {
            var rutaEntity = context.Ruta.FirstOrDefault(r => r.Id == IdRuta);

            if (rutaEntity != null)
            {
                var rutaModelAccess = new RutaModelAccess
                {
                    IdRuta = rutaEntity.Id,
                    Origen = rutaEntity.Origen,
                    Destino = rutaEntity.Destino,
                    FechaCreacion = rutaEntity.FechaCreacion
                };

                return rutaModelAccess;
            }

            return null!;
        }

        public void SaveRuta(RutaSaveModel saveModel)
        {
            var ruta = new Ruta
            {
                Origen = saveModel.Origen,
                Destino = saveModel.Destino,
                FechaCreacion = saveModel.FechaCreacion ?? DateTime.Now // Si no se proporciona una fecha, se utiliza la fecha actual
            };

            context.Ruta.Add(ruta);
            context.SaveChanges();
        }

        public void UpdateRuta(RutaUpdateModel updateModel)
        {
            var ruta = context.Ruta.FirstOrDefault(r => r.Id == updateModel.IdRuta);

            if (ruta != null)
            {
                ruta.Origen = updateModel.Origen;
                ruta.Destino = updateModel.Destino;
                ruta.FechaCreacion = updateModel.FechaCreacion ?? ruta.FechaCreacion; // Si no se proporciona una fecha, se conserva la fecha original

                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("La ruta especificada no existe.");
            };
        }
    }
}
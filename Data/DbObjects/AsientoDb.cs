using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Exceptions;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class AsientoDb : IAsientoDb
    {
        private readonly BoletosBusContext context;
        private readonly int idBus;
        Asiento asientoEliminar = null;

        public AsientoDb(BoletosBusContext context) {
            this.context = context;
        }

        public void DeleteAsiento(AsientoDeleteModel asientoDeleteModel)
        {
            var asientoEliminar = this.context.Asiento.Find(asientoDeleteModel.IdAsiento);
            asientoEliminar.IdAsiento = asientoDeleteModel.IdAsiento;
            asientoDeleteModel.FechaEliminacion = asientoDeleteModel.FechaEliminacion;

            this.context.Asiento.Update(asientoEliminar);
            this.context.SaveChanges();
        }

        public List<AsientoModelsAccess> GetAsientos()
        {
            return this.context.Asiento.Select(asiento => new AsientoModelsAccess(){
                IdBus = (int)idBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = (int)asiento.NumeroAsiento,
                FechaCreacion = asiento.FechaCreacion
            }).ToList();
        }

        public AsientoModelsAccess GetAsientos(int IdAsiento)
        {
            var asiento = this.context.Asiento.Find(IdAsiento);

            int? idBus = asiento?.IdBus;
            AsientoModelsAccess asientoModelsAccess = new AsientoModelsAccess()
            {
                IdBus = (int)idBus,
                NumeroPiso = asiento?.NumeroPiso,
                NumeroAsiento = (int)asiento.NumeroAsiento,
                FechaCreacion = asiento.FechaCreacion
            };
            return asientoModelsAccess;
        }

        public void SaveAsiento(AsientoSaveModel asientoSaveModel)
        {
            Asiento asiento = new Asiento() 
            {
                IdBus = asientoSaveModel.IdBus,
                NumeroPiso = asientoSaveModel.NumeroPiso,
                NumeroAsiento = asientoSaveModel.NumeroAsiento

            };
            this.context.Asiento.Add(asiento);
            this.context.SaveChanges();
        }

        public void UpdateAsiento(AsientoUpdateModel asientoUpdateModel)
        {
            Asiento asientoActualizar = this.context.Asiento.Find(asientoUpdateModel.IdAsiento);



            asientoActualizar.FechaModificacion = asientoUpdateModel.FechaModificacion;
            asientoActualizar.IdAsiento = asientoUpdateModel.IdAsiento;
            asientoActualizar.NumeroPiso = asientoUpdateModel?.NumeroPiso;
            asientoActualizar.NumeroAsiento = asientoUpdateModel.NumeroAsiento;
            asientoActualizar.IdBus = asientoUpdateModel.IdBus;

            this.context.Asiento.Update(asientoActualizar);
            this.context.SaveChanges();
        }
    }
}

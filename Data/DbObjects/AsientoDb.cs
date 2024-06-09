using System;
using System.Collections.Generic;
using System.Linq;
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

        public AsientoDb(BoletosBusContext context)
        {
            this.context = context;
        }


        public void DeleteAsiento(AsientoDeleteModel asientoDeleteModel)
        {
            try
            {
                var asientoEliminar = this.context.Asiento.Find(asientoDeleteModel.IdAsiento);

                if (asientoEliminar != null)
                {
                    this.context.Asiento.Remove(asientoEliminar);
                    this.context.SaveChanges();
                }
                else
                {
                    throw new AsientoDbException($"No se pudo encontrar el asiento con Id: {asientoDeleteModel.IdAsiento} para eliminar...");
                }
            }
            catch (Exception ex)
            {
                throw new AsientoDbException("Error al intentar eliminar el asiento...", ex);
            }

        }

        public List<AsientoModelsAccess> GetAsientos()
        {
            try
            {
                return this.context.Asiento.Select(asiento => new AsientoModelsAccess()
                {
                    IdBus = (int)asiento.IdBus,
                    NumeroPiso = asiento.NumeroPiso,
                    NumeroAsiento = (int)asiento.NumeroAsiento,
                    FechaCreacion = asiento.FechaCreacion
                }).ToList();
            }
            catch (Exception ex) 
            {
                throw new AsientoDbException("Error, no se pudieron obtener todos los asientos", ex);
            }
        }

        public AsientoModelsAccess GetAsientos(int IdAsiento)
        {
            var asiento = this.context.Asiento.Find(IdAsiento);
            if (asiento == null)
            {
                throw new AsientoDbException($"No se pudo encontrar el asiento con Id: {IdAsiento}...");
            }

            return new AsientoModelsAccess()
            {
                IdBus = (int)asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = (int)asiento.NumeroAsiento,
                FechaCreacion = asiento.FechaCreacion
            };
        }

        public void SaveAsiento(AsientoSaveModel asientoSaveModel)
        {
            try
            {
                var nuevoAsiento = new Asiento
                {
                    NumeroAsiento = asientoSaveModel.NumeroAsiento
                };

                this.context.Asiento.Add(nuevoAsiento);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new AsientoDbException("Error, no se pudo guardar...", ex);
            }
        }

        public void UpdateAsiento(AsientoUpdateModel asientoUpdateModel)
        {
            try
            {
                var asientoExistente = this.context.Asiento.Find(asientoUpdateModel.IdAsiento);

                if (asientoExistente == null)
                {
                    throw new AsientoDbException("El asiento no se encontró en la base de datos.");
                }

                asientoExistente.IdAsiento = asientoUpdateModel.IdAsiento;
                asientoExistente.IdBus = asientoUpdateModel.IdBus;
                asientoExistente.NumeroPiso = asientoUpdateModel.NumeroPiso;
                asientoExistente.NumeroAsiento = asientoUpdateModel.NumeroAsiento;
                asientoExistente.FechaModificacion = asientoUpdateModel.FechaModificacion;

                this.context.Asiento.Update(asientoExistente);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new AsientoDbException("Error, no se pudo actualizar...", ex);
            }
        }
    }
}

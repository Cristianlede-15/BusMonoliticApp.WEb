using System;
using System.Collections.Generic;
using System.Linq;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.DbObjects.Dataconsultation;
using BusTicketsMonolitic.Web.Data.Exceptions;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class AsientoDb : ClaseBaseConsultas<Asiento, AsientoModelsAccess, int>
    {
        public AsientoDb(BoletosBusContext context) : base(context) { }

        public override void Delete(int idAsiento)
        {
            var asientoEliminar = this.context.Asiento.Find(idAsiento);
            if (asientoEliminar != null)
            {
                this.context.Asiento.Remove(asientoEliminar);
                this.context.SaveChanges();
            }
            else
            {
                throw new AsientoDbException($"No se pudo encontrar el asiento con Id: {idAsiento} para eliminar...");
            }
        }

        public override List<AsientoModelsAccess> GetAll()
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

        public override AsientoModelsAccess GetById(int idAsiento)
        {
            var asiento = this.context.Asiento.Find(idAsiento);
            if (asiento == null)
            {
                throw new AsientoDbException($"No se pudo encontrar el asiento con Id: {idAsiento}...");
            }

            return new AsientoModelsAccess()
            {
                IdBus = (int)asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = (int)asiento.NumeroAsiento,
                FechaCreacion = asiento.FechaCreacion
            };
        }

        public override void Save(Asiento asiento)
        {
            try
            {
                this.context.Asiento.Add(asiento);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new AsientoDbException("Error, no se pudo guardar...", ex);
            }
        }

        public override void Update(Asiento asiento)
        {
            try
            {
                this.context.Asiento.Update(asiento);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new AsientoDbException("Error, no se pudo actualizar...", ex);
            }
        }
    }
}

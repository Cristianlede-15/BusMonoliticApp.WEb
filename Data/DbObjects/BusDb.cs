using System;
using System.Collections.Generic;
using System.Linq;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Exceptions;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class BusDb : IBusDb
    {
        private readonly BoletosBusContext context;

        public BusDb(BoletosBusContext context)
        {
            this.context = context;
        }

        public void DeleteBus(BusDeleteModel busDeleteModel)
        {
            try
            {
                var busEliminar = this.context.Bus.Find(busDeleteModel.IdBus);

                if (busEliminar != null)
                {
                    this.context.Bus.Remove(busEliminar);
                    this.context.SaveChanges();
                }
                else
                {
                    throw new BusDbException($"No se pudo encontrar el bus con Id: {busDeleteModel.IdBus} para eliminar...");
                }
            }
            catch (Exception ex)
            {
                throw new BusDbException("Error al intentar eliminar el bus...", ex);
            }
        }

        public List<BusModelsAccess> GetBus()
        {
            try
            {
                return this.context.Bus.Select(bus => new BusModelsAccess()
                {
                    IdBus = bus.Id,
                    NumeroPlaca = bus.NumeroPlaca,
                    Nombre = bus.Nombre,
                    CapacidadTotal = (int)bus.CapacidadTotal
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new BusDbException("Error, no se pudieron obtener todos los buses...", ex);
            }
        }

        public BusModelsAccess GetBus(int IdBus)
        {
            var bus = this.context.Bus.Find(IdBus);
            if (bus == null)
            {
                throw new BusDbException($"No se pudo encontrar el bus con Id: {IdBus}...");
            }

            return new BusModelsAccess()
            {
                IdBus = bus.Id,
                NumeroPlaca = bus.NumeroPlaca,
                Nombre = bus.Nombre,
                CapacidadTotal = (int)bus.CapacidadTotal
            };
        }

        public void SaveBus(BusSaveModel busSaveModel)
        {
            try
            {
                var nuevoBus = new Bus
                {
                    IdBus = busSaveModel.IdBus,
                    NumeroPlaca = busSaveModel.NumeroPlaca,
                    Nombre = busSaveModel.Nombre,
                    CapacidadPiso1 = busSaveModel.CapacidadPiso1,
                    CapacidadPiso2 = busSaveModel.CapacidadPiso2,
                    FechaCreacion = busSaveModel.FechaCreacion

                };

                context.Bus.Add(nuevoBus);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new BusDbException("Error, no se pudo guardar el bus...", ex);
            }
        }

        public void UpdateBus(BusUpdateModel busUpdateModel)
        {
            try
            {
                var busExistente = context.Bus.Find(busUpdateModel.IdBus);

                if (busExistente == null)
                {
                    throw new BusDbException($"No se encontró el bus con Id: {busUpdateModel.IdBus} para actualizar...");
                }

                busExistente.Nombre = busUpdateModel.Nombre;
                busExistente.IdBus = busUpdateModel.IdBus;
                busExistente.Nombre = busUpdateModel.Nombre;
                busExistente.CapacidadPiso1 = busUpdateModel.CapacidadPiso1;
                busExistente.CapacidadPiso2 = busUpdateModel.CapacidadPiso2;
                busExistente.FechaCreacion = busUpdateModel.FechaModificacion;



                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new BusDbException("Error, no se pudo actualizar el bus...", ex);
            }
        }
    }
}

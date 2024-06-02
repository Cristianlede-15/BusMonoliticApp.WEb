using System;
using System.Collections.Generic;
using System.Linq;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.DbObjects.Dataconsultation;
using BusTicketsMonolitic.Web.Data.Exceptions;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class BusDb : ClaseBaseConsultas<Bus, BusModelsAccess, int>
    {
        public BusDb(BoletosBusContext context) : base(context) { }

        public override void Delete(int idBus)
        {
            var busEliminar = context.Bus.Find(idBus);
            if (busEliminar != null)
            {
                context.Bus.Remove(busEliminar);
                context.SaveChanges();
            }
            else
            {
                throw new BusDbException($"No se pudo encontrar el bus con Id: {idBus} para eliminar...");
            }
        }

        public override List<BusModelsAccess> GetAll()
        {
            try
            {
                return context.Bus.Select(bus => new BusModelsAccess()
                {
                    IdBus = bus.IdBus,
                    NumeroPlaca = bus.NumeroPlaca,
                    CapacidadTotal = (int)bus.CapacidadTotal,
                    Disponible = (bool)bus.Disponible
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new BusDbException("Error al querer encontar todos los buses...", ex);
            }
        }

        public override BusModelsAccess GetById(int idBus)
        {
            var bus = context.Bus.Find(idBus);
            if (bus == null)
            {
                throw new BusDbException($"No se pudo encontar el bus con Id: {idBus}...");
            }

            return new BusModelsAccess()
            {
                IdBus = bus.IdBus,
                NumeroPlaca = bus.NumeroPlaca,
                Disponible = (bool)bus.Disponible
            };
        }

        public override void Save(Bus bus)
        {
            try
            {
                context.Bus.Add(bus);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new BusDbException("Error, no se pudo guardar el bus...", ex);
            }
        }

        public override void Update(Bus bus)
        {
            try
            {
                context.Bus.Update(bus);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new BusDbException("Error, no se pudo actualizar el bus...", ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.DbObjects.Dataconsultation;
using BusTicketsMonolitic.Web.Data.Exceptions;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class ClienteDb : ClaseBaseConsultas<Cliente, ClienteModelsAccess, int>
    {
        public ClienteDb(BoletosBusContext context) : base(context) { }

        public override void Delete(int idCliente)
        {
            var clienteEliminar = context.Cliente.Find(idCliente);
            if (clienteEliminar != null)
            {
                context.Cliente.Remove(clienteEliminar);
                context.SaveChanges();
            }
            else
            {
                throw new ClienteDbException($"No se pudo encontrar el cliente con Id: {idCliente} para eliminar...");
            }
        }

        public override List<ClienteModelsAccess> GetAll()
        {
            try
            {
                return context.Cliente.Select(cliente => new ClienteModelsAccess()
                {
                    IdCliente = cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new ClienteDbException("Error al tratar de obtener todos los clientes...", ex);
            }
        }

        public override ClienteModelsAccess GetById(int idCliente)
        {
            var cliente = context.Cliente.Find(idCliente);
            if (cliente == null)
            {
                throw new ClienteDbException($"No se pudo encontrar el cliente con Id: {idCliente}...");
            }

            return new ClienteModelsAccess()
            {
                IdCliente = cliente.IdCliente,
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Email = cliente.Email
            };
        }

        public override void Save(Cliente cliente)
        {
            try
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ClienteDbException("Error, no se pudo guardar el cliente...", ex);
            }
        }

        public override void Update(Cliente cliente)
        {
            try
            {
                context.Cliente.Update(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ClienteDbException("Error, no se pudo actualizar el cliente...", ex);
            }
        }
    }
}

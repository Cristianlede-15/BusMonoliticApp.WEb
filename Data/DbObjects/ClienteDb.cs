using System;
using System.Collections.Generic;
using System.Linq;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Exceptions;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class ClienteDb : IClienteDb
    {
        private readonly BoletosBusContext context;

        public ClienteDb(BoletosBusContext context)
        {
            this.context = context;
        }

        public void DeleteCliente(ClienteDeleteModel clienteDeleteModel)
        {
            try
            {
                var clienteEliminar = this.context.Cliente.Find(clienteDeleteModel.IdCliente);

                if (clienteEliminar != null)
                {
                    this.context.Cliente.Remove(clienteEliminar);
                    this.context.SaveChanges();
                }
                else
                {
                    throw new ClienteDbException($"No se pudo encontrar el cliente con Id: {clienteDeleteModel.IdCliente} para eliminar...");
                }
            }
            catch (Exception ex)
            {
                throw new ClienteDbException("Error al intentar eliminar el cliente...", ex);
            }
        }

        public List<ClienteModelsAccess> GetClientes()
        {
            try
            {
                return this.context.Cliente.Select(cliente => new ClienteModelsAccess()
                {
                    IdCliente = cliente.Id,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new ClienteDbException("Error, no se pudieron obtener todos los clientes", ex);
            }
        }

        public ClienteModelsAccess GetClientes(int IdCliente)
        {
            var cliente = this.context.Cliente.Find(IdCliente);
            if (cliente == null)
            {
                throw new ClienteDbException($"No se pudo encontrar el cliente con Id: {IdCliente}...");
            }

            return new ClienteModelsAccess()
            {
                IdCliente = cliente.IdCliente,
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Email = cliente.Email
            };
        }

        public void SaveCliente(ClienteSaveModel clienteSaveModel)
        {
            try
            {
                var nuevoCliente = new Cliente
                {
                    Nombre = clienteSaveModel.Nombre,
                    Telefono = clienteSaveModel.Telefono,
                    Email = clienteSaveModel.Email,
                    IdCliente = clienteSaveModel.IdCliente
                };

                context.Cliente.Add(nuevoCliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ClienteDbException("Error, no se pudo guardar el cliente...", ex);
            }
        }

        public void UpdateCliente(ClienteUpdateModel clienteUpdateModel)
        {
            try
            {
                var clienteExistente = context.Cliente.Find(clienteUpdateModel.IdCliente);

                if (clienteExistente == null)
                {
                    throw new ClienteDbException($"No se encontró el cliente con Id: {clienteUpdateModel.IdCliente} para actualizar...");
                }

                clienteExistente.Nombre = clienteUpdateModel.Nombre;
                clienteExistente.Telefono = clienteUpdateModel.Telefono;
                clienteExistente.Email = clienteUpdateModel.Email;
                clienteExistente.IdCliente = clienteUpdateModel.IdCliente;


                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ClienteDbException("Error, no se pudo actualizar el cliente...", ex);
            }
        }
    }
}

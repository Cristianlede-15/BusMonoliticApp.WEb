using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;
using Microsoft.Extensions.Logging;
using System;

namespace BusTicketsMonolitic.Web.BL.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteDb clienteDb;
        private readonly ILogger<ClienteService> logger;

        public ClienteService(IClienteDb clienteDb, ILogger<ClienteService> logger)
        {
            this.clienteDb = clienteDb;
            this.logger = logger;
        }

        public ServiceResult DeleteCliente(ClienteDeleteModel clienteDelete)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                clienteDb.DeleteCliente(clienteDelete);
                result.Success = true;
                result.Message = "Cliente eliminado correctamente.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al eliminar el cliente: " + ex.Message;
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetCliente()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = clienteDb.GetClientes();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al obtener los clientes: " + ex.Message;
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetCliente(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var cliente = clienteDb.GetClientes(id);
                if (cliente != null)
                {
                    result.Data = cliente;
                    result.Success = true;
                }
                else
                {
                    result.Success = false;
                    result.Message = "Cliente no encontrado.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al obtener el cliente: " + ex.Message;
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveCliente(ClienteSaveModel clienteSave)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (string.IsNullOrEmpty(clienteSave.Nombre) || clienteSave.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El nombre del cliente es inválido.";
                    return result;
                }

                if (!string.IsNullOrEmpty(clienteSave.Telefono) && clienteSave.Telefono.Length > 20)
                {
                    result.Success = false;
                    result.Message = "El teléfono del cliente es inválido.";
                    return result;
                }

                if (!string.IsNullOrEmpty(clienteSave.Email) && clienteSave.Email.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El email del cliente es inválido.";
                    return result;
                }

                clienteDb.SaveCliente(clienteSave);
                result.Success = true;
                result.Message = "Cliente guardado correctamente.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al guardar el cliente: " + ex.Message;
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateCliente(ClienteUpdateModel clienteUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (string.IsNullOrEmpty(clienteUpdate.Nombre) || clienteUpdate.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El nombre del cliente es inválido.";
                    return result;
                }

                if (!string.IsNullOrEmpty(clienteUpdate.Telefono) && clienteUpdate.Telefono.Length > 20)
                {
                    result.Success = false;
                    result.Message = "El teléfono del cliente es inválido.";
                    return result;
                }

                if (!string.IsNullOrEmpty(clienteUpdate.Email) && clienteUpdate.Email.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El email del cliente es inválido.";
                    return result;
                }

                clienteDb.UpdateCliente(clienteUpdate);
                result.Success = true;
                result.Message = "Cliente actualizado correctamente.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al actualizar el cliente: " + ex.Message;
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
    }
}

using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;
using Microsoft.Extensions.Logging;
using System;

namespace BusTicketsMonolitic.Web.BL.Services
{
    public class BusService : IBusService
    {
        private readonly IBusDb busDb;
        private readonly ILogger<BusService> logger;

        public BusService(IBusDb busDb, ILogger<BusService> logger)
        {
            this.busDb = busDb;
            this.logger = logger;
        }

        public ServiceResult DeleteBus(BusDeleteModel busDelete)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                busDb.DeleteBus(busDelete);
                result.Success = true;
                result.Message = "Bus eliminado correctamente.";
                logger.LogInformation("Bus eliminado correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al eliminar el bus: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetBus(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var bus = busDb.GetBus(id);
                if (bus != null)
                {
                    result.Data = bus;
                    result.Success = true;
                    logger.LogInformation("Bus obtenido correctamente.");
                }
                else
                {
                    result.Success = false;
                    result.Message = "Bus no encontrado.";
                    logger.LogWarning("Bus con id {Id} no encontrado.", id);
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al obtener el bus: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetBuses()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = busDb.GetBus();
                result.Success = true;
                logger.LogInformation("Buses obtenidos correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al obtener los buses: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult SaveBus(BusSaveModel busSave)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (string.IsNullOrWhiteSpace(busSave.NumeroPlaca) || busSave.NumeroPlaca.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El NumeroPlaca es inválido.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (string.IsNullOrWhiteSpace(busSave.Nombre) || busSave.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El Nombre es inválido.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (busSave.CapacidadPiso1 <= 0)
                {
                    result.Success = false;
                    result.Message = "La CapacidadPiso1 debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (busSave.CapacidadPiso2 <= 0)
                {
                    result.Success = false;
                    result.Message = "La CapacidadPiso2 debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (busSave.Disponible == null)
                {
                    result.Success = false;
                    result.Message = "El campo Disponible es inválido.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (busSave.FechaCreacion == null || busSave.FechaCreacion == DateTime.MinValue)
                {
                    result.Success = false;
                    result.Message = "La FechaCreacion es inválida.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                busDb.SaveBus(busSave);
                result.Success = true;
                result.Message = "Bus guardado correctamente.";
                logger.LogInformation("Bus guardado correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al guardar el bus: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult UpdateBuses(BusUpdateModel busUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (string.IsNullOrWhiteSpace(busUpdate.NumeroPlaca) || busUpdate.NumeroPlaca.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El NumeroPlaca es inválido.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (string.IsNullOrWhiteSpace(busUpdate.Nombre) || busUpdate.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El Nombre es inválido.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (busUpdate.CapacidadPiso1 <= 0)
                {
                    result.Success = false;
                    result.Message = "La CapacidadPiso1 debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (busUpdate.CapacidadPiso2 <= 0)
                {
                    result.Success = false;
                    result.Message = "La CapacidadPiso2 debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (busUpdate.Disponible == null)
                {
                    result.Success = false;
                    result.Message = "El campo Disponible es inválido.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                busDb.UpdateBus(busUpdate);
                result.Success = true;
                result.Message = "Bus actualizado correctamente.";
                logger.LogInformation("Bus actualizado correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al actualizar el bus: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }
    }
}

using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.DbObjects;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;
using Microsoft.Extensions.Logging;
using System;

namespace BusTicketsMonolitic.Web.BL.Services
{
    public class AsientoService : IAsientoService
    {
        private readonly IAsientoDb asientoDb;
        private readonly ILogger<AsientoService> logger;

        public AsientoService(IAsientoDb asientoDb, ILogger<AsientoService> logger)
        {
            this.asientoDb = asientoDb;
            this.logger = logger;
        }

        public ServiceResult DeleteAsientos(AsientoDeleteModel asientoDelete)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                asientoDb.DeleteAsiento(asientoDelete);
                result.Success = true;
                result.Message = "Asientos eliminados correctamente.";
                logger.LogInformation("Asientos eliminados correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al eliminar los asientos: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetAsiento(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var asiento = asientoDb.GetAsientos(id);
                if (asiento != null)
                {
                    result.Data = asiento;
                    result.Success = true;
                    logger.LogInformation("Asiento obtenido correctamente.");
                }
                else
                {
                    result.Success = false;
                    result.Message = "Asiento no encontrado.";
                    logger.LogWarning("Asiento con id {Id} no encontrado.", id);
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al obtener el asiento: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetAsientos()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = asientoDb.GetAsientos();
                result.Success = true;
                logger.LogInformation("Asientos obtenidos correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al obtener los asientos: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult SaveAsiento(AsientoSaveModel asientoSave)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (asientoSave.IdBus <= 0)
                {
                    result.Success = false;
                    result.Message = "El IdBus debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (asientoSave.NumeroPiso <= 0)
                {
                    result.Success = false;
                    result.Message = "El NumeroPiso debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (asientoSave.NumeroAsiento <= 0)
                {
                    result.Success = false;
                    result.Message = "El NumeroAsiento debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (asientoSave.FechaCreacion == null || asientoSave.FechaCreacion == DateTime.MinValue)
                {
                    result.Success = false;
                    result.Message = "La FechaCreacion es inválida.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                asientoDb.SaveAsiento(asientoSave);
                result.Success = true;
                result.Message = "Asiento guardado correctamente.";
                logger.LogInformation("Asiento guardado correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al guardar el asiento: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult UpdateAsientos(AsientoUpdateModel asientoUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (asientoUpdate.IdBus <= 0)
                {
                    result.Success = false;
                    result.Message = "El IdBus debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (asientoUpdate.NumeroPiso <= 0)
                {
                    result.Success = false;
                    result.Message = "El NumeroPiso debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }

                if (asientoUpdate.NumeroAsiento <= 0)
                {
                    result.Success = false;
                    result.Message = "El NumeroAsiento debe ser un entero positivo.";
                    logger.LogWarning(result.Message);
                    return result;
                }



                asientoDb.UpdateAsiento(asientoUpdate);
                result.Success = true;
                result.Message = "Asientos actualizados correctamente.";
                logger.LogInformation("Asientos actualizados correctamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al actualizar los asientos: " + ex.Message;
                logger.LogError(ex, result.Message);
            }
            return result;
        }
    }
}

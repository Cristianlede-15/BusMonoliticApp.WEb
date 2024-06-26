using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.BL.Validaciones;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;
using Microsoft.Extensions.Logging;

namespace BusMonoliticApp.Web.BL.Services
{
    public class ReservaDetalleService : Validaciones, IReservaDetalleService 
    {
       private readonly IReservaDetalleDb reservaDetalleDb;
        private readonly ILogger<ReservaDetalleService> logger;

        public ReservaDetalleService(IReservaDetalleDb reservaDetalleDb, ILogger<ReservaDetalleService> logger)
        {
            this.reservaDetalleDb = reservaDetalleDb;
            this.logger = logger;
        }

        public ServiceResult GetReservaDetalles()
        {
            ServiceResult result = new ServiceResult();
            
            try
            {
                result.Data = reservaDetalleDb.GetReservaDetalle();
            }
            catch (Exception ex)
            {
                
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los detalles de las reservas.";
                this.logger.LogError(result.Message,ex.ToString());
            }
            return result;
        }
        public ServiceResult GetReservaDetalles(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = reservaDetalleDb.GetReservaDetalle(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los detalles de las reservas.";
                this.logger.LogError(result.Message, ex.ToString());


            }
            return result ;
        }

        public ServiceResult SaveReservaDetalles(ReservaDetalleSaveModel reservaDetalleSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(reservaDetalleSaveModel, result);
                this.reservaDetalleDb.SaveReservaDetalle(reservaDetalleSaveModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result ;
        }

        public ServiceResult UpdateReservaDetalles(ReservaDetalleUpdateModel reservaDetalleUpdateModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(reservaDetalleUpdateModel, result);
                this.reservaDetalleDb.UpdateReservaDetalle(reservaDetalleUpdateModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error atualizando los datos.";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
        }

        public ServiceResult DeleteReservaDetalles(ReservaDetalleDeleteModel reservaDetalleDeleteModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(reservaDetalleDeleteModel, result);
                this.reservaDetalleDb.DeleteReservaDetalle(reservaDetalleDeleteModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error eliminando los detalles de esta reserva.";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
        }
    }
}
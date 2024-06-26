using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaModelDb;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Validaciones;
using BusTicketsMonolitic.Web.Data.Models.Reserva;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;

namespace BusMonoliticApp.Web.BL.Services
{
    public class ReservaService : Validaciones, IReservaService
    {
        private readonly IReservaDb reservaDb;
        private readonly ILogger<ReservaService> logger;
        public ReservaService(IReservaDb reservaDb, ILogger<ReservaService> logger)
        {
            this.reservaDb = reservaDb;
            this.logger = logger;
        }

        public ServiceResult GetReservas()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = reservaDb.GetReserva();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las reservas.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetReservas(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = reservaDb.GetReserva(id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las reservas.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveReserva(ReservaSaveModel reservaSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(reservaSaveModel, result);
                this.ValidacionMayor0(reservaSaveModel,result);
                this.reservaDb.SaveReserva(reservaSaveModel);
            }
            catch (Exception ex)
            {

                result.Success=false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message,ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateReservas(ReservaUpdateModel reservaUpdateModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(reservaUpdateModel, result);
                this.ValidacionMayor0(reservaUpdateModel, result);
                this.reservaDb.UpdaterReserva(reservaUpdateModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error atualizando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult DeleteReservas(ReservaDeleteModel reservaDeleteModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(reservaDeleteModel, result);
                this.reservaDb.DeleteReserva(reservaDeleteModel);
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

using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ViajeModelDb;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.BL.Validaciones;
using BusTicketsMonolitic.Web.Data.Models.Viaje;

namespace BusMonoliticApp.Web.BL.Services
{
    public class ViajeService : Validaciones,IViajeService
    {
        private IViajeDb viajeDb;
        private readonly ILogger<ViajeService> logger;
        public ViajeService(IViajeDb viajeDb,ILogger<ViajeService> logger)
        {
            this.viajeDb = viajeDb;
            this.logger = logger;
        }

        public ServiceResult GetViaje()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = viajeDb.GetViaje();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los viajes";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetViaje(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = viajeDb.GetViaje(id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los viajes";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveViaje(ViajeSaveModel viajeSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(viajeSaveModel,result);
                this.viajeDb.SaveViaje(viajeSaveModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult UpDateViaje(ViajeUpdateModel viajeUpdateModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(viajeUpdateModel,result);
                this.viajeDb.UpdateViaje(viajeUpdateModel);

            }
            catch (Exception ex)
            {

                result.Success=false;
                result.Message = "Ocurio un error actualizando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
        public ServiceResult DeleteReservas(ViajeDeleteModel viajeDeleteModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(viajeDeleteModel, result);
                this.viajeDb.DeleteViaje(viajeDeleteModel);

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurio un error Eliminando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
    }
}
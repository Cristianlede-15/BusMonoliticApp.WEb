using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaModelDb;
using BusMonoliticApp.Web.Data.Models.Ruta;
using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.BL.Validaciones;

namespace BusMonoliticApp.Web.BL.Services
{
    public class RutaService : Validaciones,IRutaService
    {
        private readonly IRutaDb rutaDb;
        private readonly ILogger<RutaService> logger;

        public RutaService(IRutaDb rutaDb,ILogger<RutaService> logger)
        {
            this.rutaDb = rutaDb;
            this.logger = logger;
        }

        public ServiceResult GetRutas()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = rutaDb.GetRutas();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las rutas.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetRutas(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = rutaDb.GetRutas(id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las rutas.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveRuta(RutaSaveModel rutaSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(rutaSaveModel, result);
                this.ValidacionLongitud(rutaSaveModel, result);
                this.rutaDb.SaveRuta(rutaSaveModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult UpDateRutas(RutaUpdateModel rutaUpdateModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(rutaUpdateModel, result);
                this.ValidacionLongitud(rutaUpdateModel, result);
                this.rutaDb.UpdateRuta(rutaUpdateModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error atualizando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult DeleteRuta(RutaDeleteModel rutaDeleteModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.ValidacionNoNull(rutaDeleteModel, result);
                this.ValidacionLongitud(rutaDeleteModel, result);
                this.rutaDb.DeleteRuta(rutaDeleteModel);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error eliminando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
    }
}

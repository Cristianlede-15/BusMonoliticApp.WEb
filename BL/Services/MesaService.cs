
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;

namespace BusMonoliticApp.Web.BL.Services
{
    public class MesaService : IMesaService
    {
        private readonly IMesaDb MesaDb;

        public MesaService(IMesaDb MesaDb)
        {
            this.MesaDb = MesaDb;
        }

        public ServiceResult ActualizarMesa(MesaUpdateModel UpdateMesa)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (UpdateMesa is null)
                {
                    result.Success = false;
                    result.Message = "";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo actualizar los usuarios";
            }
            return result;
        }

        public ServiceResult DeleteMesa(MesaDeleteModel DeleteMesa)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo eliminar las mesas";
            }
            return result;
        }


        public ServiceResult GetMesas(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.MesaDb.GetMesa(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo obtener los usuarios";
            }
            return result;
        }

        public ServiceResult SaveMesa(MesaSaveModel SaveMesa)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo guardar la mesa";
            }
            return result;
        }

        ServiceResult IMesaService.GetMesa()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = MesaDb.GetMesa();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo obtener las mesas";
            }
            return result;
        }
    }
}


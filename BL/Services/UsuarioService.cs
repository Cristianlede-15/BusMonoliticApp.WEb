
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.BL.Interfaces;

namespace BusMonoliticApp.Web.BL.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioDb usuarioDb;

        public UsuarioService(IUsuarioDb usuarioDb)
        {
            this.usuarioDb = usuarioDb;
        }

        public ServiceResult GetUsuario()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = usuarioDb.GetUsuario();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo obtener los usuarios";
            }
            return result;
        }

        public ServiceResult SaveUsuario(UsuarioSaveModel SaveUsuario)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = usuarioDb.GetUsuario();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error guardando el usuario";
            }
            return result;
        }

        public ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioupdate)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (usuarioupdate is null)
                {
                    result.Success = false;
                    result.Message = "";
                    return result;
                }
                
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error al actualizar el usuario";
            }
            return result;
        }
        public ServiceResult DeleteUsuario(UsuarioDeleteModel usuarioDelete)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo Eliminar el usuario";
            }
            return result;
        }

        public ServiceResult GetUsuarios(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.usuarioDb.GetUsuario(id);
            }
            catch (Exception ex)
            {
                result.Success=false;
                result.Message = "Ocurrio un error al obtener los usuarios";
            }
            return result;
        }

    }
}

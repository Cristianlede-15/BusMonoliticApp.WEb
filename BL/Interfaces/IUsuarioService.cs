using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using BusTicketsMonolitic.Web.BL.Core;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IUsuarioService
    {
        ServiceResult GetUsuario();
        ServiceResult GetUsuarios(int id);
        ServiceResult SaveUsuario(UsuarioSaveModel SaveUsuario);
        ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioupdate);
        ServiceResult DeleteUsuario (UsuarioDeleteModel usuarioDelete);

    }                 
}
                    
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;

namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IUsuarioDb 
    {
        void SaveUsuario (UsuarioSaveModel SaveUsuario);
        void UpdateUsuario (UsuarioUpdateModel usuarioupdate);
        void DeleteUsuario(UsuarioDeleteModel usuarioDelete);
        List <UsuarioModel> GetUsuario();

        UsuarioModel GetUsuario(int IdUsuario);
    }
}
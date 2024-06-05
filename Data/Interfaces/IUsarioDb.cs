using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.WEb.Data.Models;

namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IUSuarioDb 
    {
        void SaveUsuario (UsuarioSaveModel usuario);
        void UpdateUsuario (UsuarioUpdateModel usuarioUpdate);
    }
}
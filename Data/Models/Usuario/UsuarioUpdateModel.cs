using BusMonoliticApp.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.Usuario;

namespace BusMonoliticApp.WEb.Data.Models 
{
    public class UsuarioUpdateModel : UsuarioModelBase
    {
        public String? Nombres {get; set;}
        public String? Apellido {get; set;}
        public String? TipoUsuario {get; set;}
        public DateTime ModifyDate {get; set;}
    }
}
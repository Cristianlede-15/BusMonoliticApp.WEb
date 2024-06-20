using BusMonoliticApp.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.Usuario;

namespace BusMonoliticApp.WEb.Data.Models 
{
    public class UsuarioUpdateModel 
    {
        public int IdUsuario { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? TipoUsuario { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
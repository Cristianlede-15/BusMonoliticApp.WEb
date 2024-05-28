using BusMonoliticApp.Web.Data.Core;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class Usuario : BaseEntity
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? TipoUsuario { get; set; }
    }
}

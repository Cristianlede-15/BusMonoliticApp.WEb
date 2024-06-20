using System.Data;

namespace BusTicketsMonolitic.Web.Data.Models.Usuario
{
    public abstract class UsuarioModelBase 
    {
        public int IdUsuario { get; set; }

        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? TipoUsuario { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime ChangeUser { get; set; }

    }
}

using BusMonoliticApp.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
namespace BusMonoliticApp.Web.Data.Entities
{
    public class Usuario : BaseEntity
    {
        [Key]
        public int IdUsuario {  get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? TipoUsuario { get; set; }
        public DateTime ModifyDate { get; internal set; }
        public DateTime ChangeUser { get; internal set; }
    }
}

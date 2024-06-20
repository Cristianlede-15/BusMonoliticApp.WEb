using BusMonoliticApp.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.Usuario;
namespace BusMonoliticApp.Web.Data.Models
{
    public class UsuarioSaveModel : UsuarioModelBase
    {
      
        public DateTime FechaCreacion { get; set; }
        public int CreationUser { get; set; }

    }
}
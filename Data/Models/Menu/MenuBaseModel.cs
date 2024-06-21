using BusTicketsMonolitic.Web.Data.Models.Usuario;

namespace BusMonoliticApp.Web.Data.Models.Menu
{


    public abstract class MenuBaseModel 
    {
            public int IdPlato { get; set; }
            public String? Nombre { get; set; }
            public String? Descripcion { get; set; }
            public decimal Precio { get; set; }
            public String? Categoria { get; set; }
        }
}

using BusMonoliticApp.Web.Data.Models.Menu;

namespace BusMonoliticApp.WEb.Data.Models
{
    public class MenuSaveModel 
    {
        public int IdPlato { get; set; }
        public String? Nombre {get; set;}        
        public String? Descripcion {get; set;}   
        public decimal Precio {get; set;}       
        public String? Categoria {get; set;}     
                                                 
    

    }
}
using BusTicketsMonolitic.Web.Data.Models.Mesa;

namespace BusMonoliticApp.WEb.Data.Models
{
    public class MesaUpdateModel 
    {
        public int IdMesa {get; set;}
        public int Capacidad {get; set;}
        public String? Estado {get; set;}
        
    }

}
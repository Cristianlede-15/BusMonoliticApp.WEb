using BusTicketsMonolitic.Web.Data.Models.Mesa;

namespace BusMonoliticApp.Web.Data.Models
{
    public class MesaModel : MesaBaseModel
    { 
        public int IdMesa {get; set;}
        public int Capacidad {get; set;}
        public String? Estado {get; set;}
    }
}
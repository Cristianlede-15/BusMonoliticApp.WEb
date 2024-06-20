using BusTicketsMonolitic.Web.Data.Models.Mesa;

namespace BusMonoliticApp.Web.Data.Models
{
public class MesaSaveModel : MesaBaseModel
    {

        public int Capacidad {get; set;}
        public String? Estado {get; set;}
}
}
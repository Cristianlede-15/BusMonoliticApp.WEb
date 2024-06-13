using BusTicketsMonolitic.Web.Data.Models.AsientoModelsDb;

namespace BusTicketsMonolitic.Web.Data.Models.AsientoModels
{
    public class AsientoUpdateModel : AsientoBaseModel
    {

        public int? NumeroPiso { get; set; }
        public int? NumeroAsiento { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

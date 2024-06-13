using BusTicketsMonolitic.Web.Data.Models.AsientoModelsDb;

namespace BusTicketsMonolitic.Web.Data.Models.AsientoModels
{
    public class AsientoSaveModel : AsientoBaseModel
    {

        public int NumeroPiso {  get; set; }    
        public int NumeroAsiento { get; set; }
        public int? CapacidadTotal { get; set; }
        public bool? Disponible { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}

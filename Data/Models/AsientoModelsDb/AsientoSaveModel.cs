namespace BusTicketsMonolitic.Web.Data.Models.AsientoModels
{
    public class AsientoSaveModel
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso {  get; set; }    
        public int NumeroAsiento { get; set; }
        public int? CapacidadTotal { get; set; }
        public bool? Disponible { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}

namespace BusTicketsMonolitic.Web.Data.Models.BusModelsDb
{
    public class BusSaveModel
    {
        public int IdBus { get; set; }
        public string? NumeroPlaca { get; set; }
        public string? Nombre { get; set; }
        public int CapacidadTotal { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}

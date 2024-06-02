namespace BusTicketsMonolitic.Web.Data.Models.BusModelsDb
{
    public class BusUpdateModel
    {
        public int IdBus { get; set; }
        public string? NumeroPlaca { get; set; }
        public string? Nombre { get; set; }
        public int CapacidadTotal { get; set; }
        public bool Disponible { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

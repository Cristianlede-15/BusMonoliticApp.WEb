namespace BusTicketsMonolitic.Web.Data.Models.BusModelsDb
{
    public class BusDeleteModel
    {
        public int IdBus { get; set; }
        public string? NumeroPlaca { get; set; }
        public bool Disponible { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}

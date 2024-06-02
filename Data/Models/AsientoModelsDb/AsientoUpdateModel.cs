namespace BusTicketsMonolitic.Web.Data.Models.AsientoModels
{
    public class AsientoUpdateModel
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int? NumeroPiso { get; set; }
        public int? NumeroAsiento { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

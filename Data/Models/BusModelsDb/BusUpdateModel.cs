namespace BusTicketsMonolitic.Web.Data.Models.BusModelsDb
{
    public class BusUpdateModel : BusBaseModel
    {

        public bool Disponible { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

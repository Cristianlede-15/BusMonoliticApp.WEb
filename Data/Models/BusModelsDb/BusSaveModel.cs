namespace BusTicketsMonolitic.Web.Data.Models.BusModelsDb
{
    public class BusSaveModel : BusBaseModel
    {

        public DateTime? FechaCreacion { get; set; }
        public object Disponible { get; internal set; }
    }
}

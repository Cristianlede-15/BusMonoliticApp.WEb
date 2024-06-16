namespace BusTicketsMonolitic.Web.Data.Models.Ruta
{
    public class RutaModelAccess
    {
        public int IdRuta { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
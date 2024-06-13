namespace BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb
{
    public class ClienteModelsAccess
    {
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public object IdCliente { get; internal set; }
    }
}

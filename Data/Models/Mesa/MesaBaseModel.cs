namespace BusTicketsMonolitic.Web.Data.Models.Mesa
{
    public abstract class MesaBaseModel
    {
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public String? Estado { get; set; }
    }
}

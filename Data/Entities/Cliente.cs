using BusTicketsMonolitic.Web.Data.Core;

namespace BusTicketsMonolitic.Web.Data.Entities
{
    public class Cliente : BaseEntitiy
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        //Hay que crear la clase pedidos

        //public ICollection<Pedido> Pedidos { get; set; }
    }
}

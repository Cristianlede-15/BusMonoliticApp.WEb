using BusTicketsMonolitic.Web.Data.Entities;

namespace BusTicketsMonolitic.Web.Data.Interfaces
{
    public interface IClienteDb
    {
        void Save(Cliente cliente);
    }
}

using BusMonoliticApp.Web.Data.Entities;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;

namespace BusTicketsMonolitic.Web.Data.Interfaces
{
    public interface IClienteDb
    {
        void SaveCliente(ClienteSaveModel clienteSaveModel);
        void DeleteCliente(ClienteDeleteModel clienteDeleteModel);
        void UpdateCliente(ClienteUpdateModel clienteUpdateModel);

        List<ClienteModelsAccess> GetClientes();
        ClienteModelsAccess GetClientes(int IdCliente);
    }
}

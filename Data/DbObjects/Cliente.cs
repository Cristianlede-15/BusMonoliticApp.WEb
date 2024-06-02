using BusMonoliticApp.Web.Data.Context;
using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;

namespace BusTicketsMonolitic.Web.Data.DbObjects
{
    public class Cliente : IClienteDb
    {
        private readonly BoletosBusContext context;

        public Cliente(BoletosBusContext context)
        {
            this.context = context;
        }
        public void DeleteCliente(ClienteDeleteModel clienteDeleteModel)
        {
            throw new NotImplementedException();
        }

        public List<ClienteModelsAccess> GetClientes()
        {
            throw new NotImplementedException();
        }

        public ClienteModelsAccess GetClientes(int IdCliente)
        {
            throw new NotImplementedException();
        }

        public void SaveCliente(ClienteSaveModel clienteSaveModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateCliente(ClienteUpdateModel clienteUpdateModel)
        {
            throw new NotImplementedException();
        }
    }
}

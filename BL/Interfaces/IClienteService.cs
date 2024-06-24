using BusTicketsMonolitic.Web.BL.Core;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IClienteService
    {
        ServiceResult GetCliente();
        ServiceResult GetCliente(int id);
        ServiceResult UpdateCliente(ClienteUpdateModel clienteUpdate);
        ServiceResult DeleteCliente(ClienteDeleteModel clienteDelete);
        ServiceResult SaveCliente(ClienteSaveModel clienteSave);
    }
}

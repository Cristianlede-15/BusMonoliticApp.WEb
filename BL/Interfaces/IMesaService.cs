using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using BusTicketsMonolitic.Web.BL.Core;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IMesaService
    {
        ServiceResult GetMesa();
        ServiceResult GetMesas(int id);
        ServiceResult SaveMesa(MesaSaveModel SaveMesa);
        ServiceResult ActualizarMesa (MesaUpdateModel UpdateMesa);
        ServiceResult DeleteMesa (MesaDeleteModel DeleteMesa);
    }
}

using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IMesaDb
    {
        void agregarMesa (MesaSaveModel SaveMesa);
        void ActualizarMesa (MesaUpdateModel UpdateMesa);
        void DeleteMesa(MesaDeleteModel DeleteMesa);
        List <MesaModel> GetMesa();

        MesaModel GetMesa(int IdMesa);
    }

}
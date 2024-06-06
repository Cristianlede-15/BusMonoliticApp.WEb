using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IMesaDb
    {
        void SaveMesa (MesaSaveModel SaveMesa);
        void UpdateMesa (MesaUpdateModel UpdateMesa);
        void DeleteMenu(MesaDeleteModel DeleteMesa);
        List <MesaModel> GetMesa();

        MesaModel GetMesa(int IdMesa);
    }

}
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IMesaDb
    {
        void SaveMesa (MesaSaveModel mesa);
        void UpdateMesa (MesaUpdateModel updateModel);
        void RemoveMenu();
    }

}
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.WEb.Data.Models;

namespace BusMonoliticApp.Web.Data.Interfaces 
{
    public interface IMenuDb
    {
        void SaveMenu(MenuSaveModel menu);
        void UpdateMenu(MenuUpdateModel updateModel);
    }


}
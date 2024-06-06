using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
namespace BusMonoliticApp.Web.Data.Interfaces 
{
    public interface IMenuDb
    {
        void SaveMenu(MenuSaveModel SaveMenu);
        void UpdateMenu(MenuUpdateModel UpdateMenu);
        void DeleteMenu(MenuDeleteModel DeleteMenu);
        List <MenuModel> GetMenu();

        MenuModel GetMenu(int IdPlato);
    }


}
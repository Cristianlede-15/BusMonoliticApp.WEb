using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using BusTicketsMonolitic.Web.BL.Core;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IMenuService
    {
        ServiceResult GetMenu();
        ServiceResult GetMenus(int id);
        ServiceResult SaveMenu(MenuSaveModel SaveMenu);
        ServiceResult UpdateMenu(MenuUpdateModel UpdateMenu);
        ServiceResult DeleteMenu(MenuDeleteModel DeleteMenu);
    }
}

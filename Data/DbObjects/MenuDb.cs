using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;

namespace BusMonoliticApp.Web.Data.DbObjects
{        
    public class MenuDb : IMenuDb
    {
        private readonly BoletosBusContext context;

        public MenuDb(BoletosBusContext context)
    {
        this.context = context;
    }

        public List<MenuModel> GetMenu()
        {
            return context.Menu
                .Select(menu => new MenuModel 
                {
                    IdPlato = menu.Id,
                    Nombre = menu.Nombre,
                    Descripcion = menu.Descripcion,
                    Precio = menu.Precio,
                    Categoria = menu.Categoria
                })
                .ToList();
        }

        public MenuModel GetMenu(int IdPlato)
        {
                        var menu = context.Menu.Find(IdPlato);
            if (menu == null)
                throw new KeyNotFoundException("Menu not found");

            return new MenuModel
            {
                IdPlato = menu.Id,
                Nombre = menu.Nombre,
                Descripcion = menu.Descripcion,
                Precio = menu.Precio,
                Categoria = menu.Categoria
            };
        }

        public void SaveMenu(MenuSaveModel SaveMenu)
        {
                        var menuEntity = new Menu
            {
                Nombre = SaveMenu.Nombre,
                Descripcion = SaveMenu.Descripcion,
                Precio = SaveMenu.Precio,
                Categoria = SaveMenu.Categoria
            };

            context.Menu.Add(menuEntity);
            context.SaveChanges();
        }

        public void UpdateMenu(MenuUpdateModel UpdateMenu)
        {
                        var menu = context.Menu.Find(UpdateMenu.IdPlato);
            if (menu == null)
                throw new KeyNotFoundException("Menu not found");

            menu.Nombre = UpdateMenu.Nombre;
            menu.Descripcion = UpdateMenu.Descripcion;
            menu.Precio = UpdateMenu.Precio;
            menu.Categoria = UpdateMenu.Categoria;

            context.Menu.Update(menu);
            context.SaveChanges();
        }
        public void DeleteMenu(MenuDeleteModel DeleteMenu)
        {
            var menu = context.Menu.Find(DeleteMenu.IdPlato);
            if (menu == null)
                throw new KeyNotFoundException("Menu not found");

            context.Menu.Remove(menu);
            context.SaveChanges();
        }
    }
    
}


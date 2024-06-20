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
            return this.context.Menu.Select(Mu => new MenuModel()
            {
                IdPlato = Mu.IdPlato,
                Nombre = Mu.Nombre,
                Descripcion = Mu.Descripcion,
                Precio = Mu.Precio,
                Categoria = Mu.Categoria,


            }).ToList();
        }

        public MenuModel GetMenu(int IdPlato)
        {
            var Menu = this.context.Menu.Find(IdPlato);
            MenuModel mesa = new MenuModel()
            {
                IdPlato = Menu.IdPlato,
                Nombre = Menu.Nombre,
                Descripcion = Menu.Descripcion,
                Precio= Menu.Precio,
                Categoria = Menu.Categoria,

                
            };
            return mesa;

        }

        public void SaveMenu(MenuSaveModel SaveMenu)
        {
            Menu menu = new Menu()
            {
                IdPlato = SaveMenu.IdPlato,
                Nombre = SaveMenu.Nombre,
                Descripcion=SaveMenu.Descripcion,
                Precio= SaveMenu.Precio,
                Categoria= SaveMenu.Categoria,

            };

            this.context.Menu.Add(menu);
            this.context.SaveChanges();
        }

        public void UpdateMenu(MenuUpdateModel UpdateMenu)
        {
            Menu MenuUpdate = this.context.Menu.Find(UpdateMenu.IdPlato);

            UpdateMenu.IdPlato = UpdateMenu.IdPlato;
            UpdateMenu.Nombre = UpdateMenu.Nombre;
            UpdateMenu.Descripcion = UpdateMenu.Descripcion;
            UpdateMenu.Precio = UpdateMenu.Precio;
            UpdateMenu.Categoria = UpdateMenu.Categoria;
    


            this.context.Menu.Update(MenuUpdate);
            this.context.SaveChanges();
        }
        public void DeleteMenu(MenuDeleteModel DeleteMenu)
        {
            throw new NotImplementedException();
        }
    }
    
}


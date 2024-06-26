using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.WEb.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuDb MenuDb;

        public MenuController(IMenuDb MenuDb)
        {
            this.MenuDb = MenuDb;
        }
        // GET: MenuController
        public ActionResult Index()
        {
            
            return View(this.MenuDb.GetMenu());
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {
            var menu = this.MenuDb.GetMenu(id);
            return View(menu);
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MenuSaveModel savemenu)
        {
            try                                    
            {
                this.MenuDb.SaveMenu(savemenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var menu = this.MenuDb.GetMenu(id);
            return View(menu);
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MenuUpdateModel UpdateMenu)
        {
            try
            {
                

                this.MenuDb.UpdateMenu(UpdateMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

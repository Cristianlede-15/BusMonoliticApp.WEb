using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioDb UsuarioDb;

        public UsuarioController(IUsuarioDb UsuarioDb)
        {
            this.UsuarioDb = UsuarioDb;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            
            return View(this.UsuarioDb.GetUsuario());
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            var usuario = this.UsuarioDb.GetUsuario(id);
            return View(usuario);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioSaveModel SaveUsuario)
        {
            try

            {
                SaveUsuario.FechaCreacion = DateTime.Now;
                this.UsuarioDb.SaveUsuario(SaveUsuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            var actualizar = this.UsuarioDb.GetUsuario(id);
            return View(actualizar);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioUpdateModel usuarioupdate)
        {
            try
            {
                usuarioupdate.FechaCreacion = DateTime.Now;
                this.UsuarioDb.UpdateUsuario(usuarioupdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
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

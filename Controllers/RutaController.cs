using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    
    public class RutaController : Controller
    {
        private readonly IRutaDb RutaDb;
        public RutaController(IRutaDb RutaDb)
        {
            this.RutaDb = RutaDb;
        }
        // GET: RutaController
        public ActionResult Index()
        {
            var Ruta = this.RutaDb.GetRutas();
            return View(Ruta);
        }

        // GET: RutaController/Details/5
        public ActionResult Details(int id)
        {
            var Ruta = this.RutaDb.GetRutas(id);
            return View(Ruta);
        }

        // GET: RutaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RutaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RutaSaveModel RutaSaveModel)
        {
            try
            {
                RutaSaveModel.FechaCreacion = DateTime.Now;
                this.RutaDb.SaveRuta(RutaSaveModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RutaController/Edit/5
        public ActionResult Edit(int id)
        {
            var Ruta = this.RutaDb.GetRutas(id);
            return View(Ruta);
        }

        // POST: RutaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RutaUpdateModel RutaUpdateModel)
        {
            try
            {
                RutaUpdateModel.FechaCreacion = DateTime.Now;
                this.RutaDb.UpdateRuta(RutaUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RutaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RutaController/Delete/5
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

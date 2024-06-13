using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class AsientoController : Controller
    {
        private readonly IAsientoDb asientoDb;

        public AsientoController(IAsientoDb asientoDb)
        {
            this.asientoDb = asientoDb;
        }

        // GET: AsientoController
        public ActionResult Index()
        {
            var asientos = this.asientoDb.GetAsientos();
            return View(asientos);
        }

        // GET: AsientoController/Details/5
        public ActionResult Details(int id)
        {
            var asiento = this.asientoDb.GetAsientos(id);
            return View(asiento);
        }

        // GET: AsientoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AsientoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AsientoSaveModel asientoSave)
        {
            try
            {
                this.asientoDb.SaveAsiento(asientoSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AsientoController/Edit/5
        public ActionResult Edit(int id)
        {
            var asiento = this.asientoDb.GetAsientos(id);
            return View(asiento);
        }

        // POST: AsientoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AsientoUpdateModel asientoUpdate)
        {
            try
            {
                asientoUpdate.FechaModificacion = DateTime.Now;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AsientoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AsientoController/Delete/5
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

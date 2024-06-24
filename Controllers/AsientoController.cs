using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.AsientoModels;
using BusTicketsMonolitic.Web.Data.Models.AsientoModelsDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class AsientoController : Controller
    {
        private readonly IAsientoService asientoService;

        public AsientoController(IAsientoService asientoService)
        {
            this.asientoService = asientoService;
        }

        // GET: AsientoController
        public ActionResult Index()
        {
            var result = this.asientoService.GetAsientos();
            if (!result.Success)
            {
                ViewBag.Message = result.Message;
            }

            var asientos = (List<AsientoModelsAccess>)result.Data;
            return View(asientos);
        }

        // GET: AsientoController/Details/5
        public ActionResult Details(int id)
        {
            var result = this.asientoService.GetAsiento(id);
            if (!result.Success)
            {
                return NotFound();
            }
            return View(result.Data);
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
                var result = this.asientoService.SaveAsiento(asientoSave);
                if (!result.Success)
                {
                    ViewBag.Message = result.Message;
                    return View(asientoSave);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(asientoSave);
            }
        }

        // GET: AsientoController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = this.asientoService.GetAsiento(id);
            if (!result.Success)
            {
                return NotFound();
            }

            var asiento = (AsientoModelsAccess)result.Data;
            var asientoUpdateModel = new AsientoUpdateModel
            {
                IdBus = asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = asiento.NumeroAsiento,
            };
            return View(asientoUpdateModel);
        }

        // POST: AsientoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AsientoUpdateModel asientoUpdate)
        {
            try
            {
                asientoUpdate.FechaModificacion = DateTime.Now;

                var result = this.asientoService.UpdateAsientos(asientoUpdate);
                if (!result.Success)
                {
                    ViewBag.Message = result.Message;
                    return View(asientoUpdate);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(asientoUpdate);
            }
        }

        // GET: AsientoController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = this.asientoService.GetAsiento(id);
            if (!result.Success)
            {
                return NotFound();
            }
            return View(result.Data);
        }

        // POST: AsientoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var result = this.asientoService.DeleteAsientos(id);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.Message = result.Message;
                var asiento = this.asientoService.GetAsiento(id).Data;
                return View(asiento);
            }
            catch
            {
                var asiento = this.asientoService.GetAsiento(id).Data;
                return View(asiento);
            }
        }
    }
}

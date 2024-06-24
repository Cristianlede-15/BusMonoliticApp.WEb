using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusService busService;

        public BusController(IBusService busService)
        {
            this.busService = busService;
        }

        // GET: BusController
        public ActionResult Index()
        {
            var result = busService.GetBuses();
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View("Error");
            }
        }

        // GET: BusController/Details/5
        public ActionResult Details(int id)
        {
            var result = busService.GetBus(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View("Error");
            }
        }

        // GET: BusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BusSaveModel busSave)
        {
            try
            {
                var result = busService.SaveBus(busSave);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMessage = result.Message;
                    return View(busSave);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = busService.GetBus(id);
            if (result.Success)
            {
                var bus = result.Data;
                var busUpdateModel = new BusUpdateModel
                {
                    IdBus = bus.IdBus,
                    Disponible = bus.Disponible,
                    NumeroPlaca = bus.NumeroPlaca,
                    Nombre = bus.Nombre,
                    CapacidadPiso1 = bus.CapacidadPiso1,
                    CapacidadPiso2 = bus.CapacidadPiso2,
                };
                return View(busUpdateModel);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View("Error");
            }
        }

        // POST: BusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BusUpdateModel busUpdate)
        {
            try
            {
                busUpdate.FechaModificacion = DateTime.Now;

                var result = busService.UpdateBuses(busUpdate);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMessage = result.Message;
                    return View(busUpdate);
                }
            }
            catch
            {
                return View(busUpdate);
            }
        }

        // GET: BusController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = busService.GetBus(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View("Error");
            }
        }

        // POST: BusController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var busDeleteModel = new BusDeleteModel { IdBus = id };
                var result = busService.DeleteBus(busDeleteModel);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMessage = result.Message;
                    return View("Error");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}

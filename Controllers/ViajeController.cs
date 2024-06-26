using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ViajeModelDb;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;
using BusTicketsMonolitic.Web.Data.Models.Viaje;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class ViajeController : Controller
    {
        private readonly IViajeService viajeService; 
        public ViajeController(IViajeService viajeService)
        {
            this.viajeService = viajeService;
        }
        // GET: ViajeController
        public ActionResult Index()
        {

            var result = this.viajeService.GetViaje();
            if (!result.Success)
            {
                ViewBag.Message = result.Message;
            }
            var Viaje = (List<ViajeModelAccess>)result.Data!;
            return View(Viaje);
        }

        // GET: ViajeController/Details/5
        public ActionResult Details(int id)
        {
            var Viaje = this.viajeService.GetViaje(id);
            return View(Viaje);
        }

        // GET: ViajeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViajeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViajeSaveModel ViajeSaveModel)
        {
            try
            {
                ViajeSaveModel.FechaCreacion = DateTime.Now;
                this.viajeService.SaveViaje(ViajeSaveModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViajeController/Edit/5
        public ActionResult Edit(int id)
        {
            var Viaje = this.viajeService.GetViaje(id);
            return View(Viaje);
        }

        // POST: ViajeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ViajeUpdateModel ViajeUpdateModel)
        {
            try
            {
                ViajeUpdateModel.FechaCreacion = DateTime.Now;
                this.viajeService.UpDateViaje(ViajeUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViajeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViajeController/Delete/5
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

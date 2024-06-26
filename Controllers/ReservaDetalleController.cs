using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;
using BusMonoliticApp.Web.BL.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusTicketsMonolitic.Web.BL.Interfaces;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class ReservaDetalleController : Controller
    {
        private readonly IReservaDetalleService ReservaDetalleService;
        public ReservaDetalleController(IReservaDetalleService ReservaDetalleService)
        {
            this.ReservaDetalleService = ReservaDetalleService;
        }
        // GET: ReservaDetalleController
        public ActionResult Index()
        {
            var result = this.ReservaDetalleService.GetReservaDetalles();
            if (!result.Success)
            {
                ViewBag.Message = result.Message;
            }
            var ReservaDetalle = (List<ReservaDetalleModelAccess>)result.Data!;
            return View(ReservaDetalle);
        }

        // GET: ReservaDetalleController/Details/5
        public ActionResult Details(int id)
        {
            var ReservaDetalle = this.ReservaDetalleService.GetReservaDetalles();
            return View(ReservaDetalle);
        }

        // GET: ReservaDetalleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaDetalleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservaDetalleSaveModel ReservaDetalleSaveModel)
        {
            try
            {
                ReservaDetalleSaveModel.FechaCreacion = DateTime.Now;
                this.ReservaDetalleService.SaveReservaDetalles(ReservaDetalleSaveModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservaDetalleController/Edit/5
        public ActionResult Edit(int id)
        {
            var ReservaDetalle = this.ReservaDetalleService.GetReservaDetalles(id);
            return View(ReservaDetalle);
        }

        // POST: ReservaDetalleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservaDetalleUpdateModel ReservaDetalleUpdateModel)
        {
            try
            {
                ReservaDetalleUpdateModel.FechaCreacion = DateTime.Now;
                this.ReservaDetalleService.UpdateReservaDetalles(ReservaDetalleUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservaDetalleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservaDetalleController/Delete/5
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

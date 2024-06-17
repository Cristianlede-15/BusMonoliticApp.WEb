using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class ReservaDetalleController : Controller
    {
        private readonly IReservaDetalleDb ReservaDetalleDb;
        public ReservaDetalleController(IReservaDetalleDb ReservaDetalleDb)
        {
            this.ReservaDetalleDb = ReservaDetalleDb;
        }
        // GET: ReservaDetalleController
        public ActionResult Index()
        {
            var ReservaDetalle = this.ReservaDetalleDb.GetReservaDetalle();
            return View(ReservaDetalle);
        }

        // GET: ReservaDetalleController/Details/5
        public ActionResult Details(int id)
        {
            var ReservaDetalle = this.ReservaDetalleDb.GetReservaDetalle();
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
        public ActionResult Create(IFormCollection collection)
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

        // GET: ReservaDetalleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservaDetalleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

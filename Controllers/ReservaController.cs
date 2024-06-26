using BusMonoliticApp.Web.BL.Core;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.DbObjects;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.ReservaModelDb;
using BusTicketsMonolitic.Web.Data.Models.ReservaModelDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class ReservaController : Controller
    {

        private readonly IReservaService reservaService;
        public ReservaController(IReservaService reservaService)
        {
            this.reservaService = reservaService;
        }
        // GET: ReservaController
        public ActionResult Index()
        {
            var result = this.reservaService.GetReservas();
            if (!result.Success)
            {
                ViewBag.Message = result.Message;
            }
            var Reserva = (List<ReservaModelAccess>)result.Data!;
            return View(Reserva);
        }

        // GET: ReservaController/Details/5
        public ActionResult Details(int id)
        {
            var Reserva = this.reservaService.GetReservas(id);
            return View(Reserva);
        }

        // GET: ReservaController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: ReservaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservaSaveModel ReservaSaveModel)
        {
            try
            {
                ReservaSaveModel.FechaCreacion = DateTime.Now;
                this.reservaService.SaveReserva(ReservaSaveModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservaController/Edit/5
        public ActionResult Edit(int id)
        {
            var Reserva = this.reservaService.GetReservas(id);
            return View(Reserva);
        }

        // POST: ReservaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservaUpdateModel ReservaUpdateModel)
        {
            try
            {
                ReservaUpdateModel.FechaCreacion = DateTime.Now;
                this.reservaService.UpdateReservas(ReservaUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservaController/Delete/5
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

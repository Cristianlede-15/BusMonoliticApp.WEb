using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models.Ruta;
using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    
    public class RutaController : Controller
    {
        private readonly IRutaService rutaService;
        public RutaController(IRutaService rutaService)
        {
            this.rutaService = rutaService;
        }
        // GET: RutaController
        public ActionResult Index()
        {
            var result = this.rutaService.GetRutas();
            if (!result.Success)
            {
                ViewBag.Message = result.Message;
            }
            var Ruta = (List<RutaModelAccess>)result.Data!;
            return View(Ruta);
        }

        // GET: RutaController/Details/5
        public ActionResult Details(int id)
        {
            var Ruta = this.rutaService.GetRutas(id);
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
                this.rutaService.SaveRuta(RutaSaveModel);
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
            var Ruta = this.rutaService.GetRutas(id);
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
                this.rutaService.UpDateRutas(RutaUpdateModel);
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

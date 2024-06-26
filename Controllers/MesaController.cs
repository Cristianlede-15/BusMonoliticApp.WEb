using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class MesaController : Controller
    {
        private readonly IMesaDb MesaDb;

        public MesaController(IMesaDb MesaDb)
        {
            this.MesaDb = MesaDb;
        }
        // GET: MesaController
        public ActionResult Index()
        {
            
            return View(this.MesaDb.GetMesa());
        }

        // GET: MesaController/Details/5
        public ActionResult Details(int id)
        {
            var mesa = this.MesaDb.GetMesa(id);
            return View(mesa);
        }

        // GET: MesaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MesaSaveModel SaveMesa)
        {
            try
            {
                this.MesaDb.agregarMesa(SaveMesa);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaController/Edit/5
        public ActionResult Edit(int id)
        {
            var actu = this.MesaDb.GetMesa(id);
            return View(actu);
        }

        // POST: MesaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MesaUpdateModel UpdateMesa)
        {
            try
            {
                this.MesaDb.ActualizarMesa(UpdateMesa);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MesaController/Delete/5
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

using BusMonoliticApp.Web.Data.Context;
using BusTicketsMonolitic.Web.Data.DbObjects;
using BusTicketsMonolitic.Web.Data.Interfaces;
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


        //------------------------
        // GET: AsientoController
        public ActionResult Index()
        {
            var asientos = this.asientoDb.GetAsientos();
            return View();
        }

        // GET: AsientoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AsientoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AsientoController/Create
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

        // GET: AsientoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AsientoController/Edit/5
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

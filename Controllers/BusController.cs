﻿using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.BusModelsDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusDb busDb;

        public BusController(IBusDb busDb)
        {
            this.busDb = busDb;
        }
        // GET: BusController
        public ActionResult Index()
        {
            var buses = this.busDb.GetBus();
            return View(buses);
        }

        // GET: BusController/Details/5
        public ActionResult Details(int id)
        {
            var bus = this.busDb.GetBus(id);
            return View(bus);
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
                this.busDb.SaveBus(busSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Edit/5
        public ActionResult Edit(int id)
        {
            var bus = this.busDb.GetBus(id);
            return View(bus);
        }

        // POST: BusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BusUpdateModel busUpdate)
        {
            try
            {
                busUpdate.FechaModificacion = DateTime.Now;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusController/Delete/5
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

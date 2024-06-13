using BusTicketsMonolitic.Web.Data.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteDb clienteDb;

        public ClienteController(IClienteDb clienteDb)
        {
            this.clienteDb = clienteDb;
        }
        // GET: ClienteController
        public ActionResult Index()
        {
            var clientes = this.clienteDb.GetClientes();
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            var clientes = this.clienteDb.GetClientes(id);
            return View(clientes);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteSaveModel clienteSave)
        {
            try
            {
                this.clienteDb.SaveCliente(clienteSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = this.clienteDb.GetClientes(id);
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteUpdateModel clienteUpdate)
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

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
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

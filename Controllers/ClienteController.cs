using BusTicketsMonolitic.Web.BL.Interfaces;
using BusTicketsMonolitic.Web.Data.Models.ClienteModelsDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketsMonolitic.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            var result = clienteService.GetCliente();
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View(new List<ClienteModelsAccess>());
            }
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            var result = clienteService.GetCliente(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View();
            }
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
            var result = clienteService.SaveCliente(clienteSave);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View(clienteSave);
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = clienteService.GetCliente(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View();
            }
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteUpdateModel clienteUpdate)
        {
            var result = clienteService.UpdateCliente(clienteUpdate);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View(clienteUpdate);
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = clienteService.GetCliente(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View();
            }
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var clienteDelete = new ClienteDeleteModel { IdCliente = id };
            var result = clienteService.DeleteCliente(clienteDelete);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.ErrorMessage = result.Message;
                return View();
            }
        }
    }
}

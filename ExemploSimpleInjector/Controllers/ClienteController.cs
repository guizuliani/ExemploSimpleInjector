using ExemploSimpleInjector.Models;
using ExemploSimpleInjector.Repositories;
using System.Web.Mvc;

namespace ExemploSimpleInjector.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteRepository _repository;

        public ClienteController(IClienteRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var clientes = _repository.ObterTodos();

            return View(clientes);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _repository.Adicionar(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

    }
}
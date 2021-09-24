using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jogo.Models;
using System.Web.Mvc;

namespace Jogo.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult ClienteView()
        {
            var cliente = new Cliente();
            return View(cliente);
        }
        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult ClienteView(Cliente cliente)
        {
                ac.CadastrarCliente(cliente);
                return View("Resultado", cliente);
        }
    }
}
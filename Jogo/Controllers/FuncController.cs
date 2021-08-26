using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jogo.Models;
using System.Web.Mvc;

namespace Jogo.Controllers
{
    public class FuncController : Controller
    {
        // GET: Func
        public ActionResult FuncView()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]

        public ActionResult FuncView(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", funcionario);
            }
            return View(funcionario);
        }
    }
}
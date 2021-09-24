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
        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult FuncView(Funcionario funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View("Resultado", funcionario);

        }
    }
}
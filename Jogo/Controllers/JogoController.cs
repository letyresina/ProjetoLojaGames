using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jogo.Models;
using System.Web.Mvc;

namespace Jogo.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult JogoView()
        {
            var jogo = new JogoClasse();
            return View(jogo);
        }
        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult JogoView(JogoClasse jogo)
        {
            ac.CadastrarJogo(jogo);
            return View("Resultado", jogo);
        }
    }
}
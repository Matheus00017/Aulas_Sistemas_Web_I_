using Microsoft.AspNetCore.Mvc;
using quetao1.Models;

namespace quetao1.controller
{
    public class HomeController : Controller
    {
      public IActionResult Index()
        {   
            Mensagem mensagem =  new Mensagem();
            mensagem.texto = "Estagiando na equipse";
            return View(mensagem);  
        }

        
        public IActionResult botao()
        {
            Mensagem mensagem = new Mensagem();
            mensagem.texto2 = "Clicou né";
            return View( "Index", mensagem);
        }

        public IActionResult esconder()
        {
            Mensagem mensagem = new Mensagem();
            mensagem.texto = "Estagiando na equipse";
            return View("Index", mensagem);
        }
    }
}

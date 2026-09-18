using Microsoft.AspNetCore.Mvc;
using Exercio_03.Models;


namespace Exercio_03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Mensagem Mensagem = new Mensagem();
            Mensagem.texto = "Boa noite Bruno";
            return View(Mensagem);
            
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Exercicio_05.Models;

namespace Exercicio_05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Numero numero = new Numero();
            numero.numero1 = 5;
            numero.numero2 = 10;
            numero.exibirSoma = false;
            return View(numero);
        }

        public IActionResult botao(int numero1, int numero2, bool exibirSoma)
        {
            Numero numero = new Numero();
            numero.numero1 = numero1;
            numero.numero2 = numero2;
            numero.soma = numero.numero1 + numero.numero2;
            numero.exibirSoma = !exibirSoma;
            return View("Index", numero);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Exercicio_09.Models;

namespace Exercicio_09.Controlles
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Calculo texto = new Calculo();
            texto.mensagem = " ";
            return View(texto);
        }

        [HttpPost]
        
        public IActionResult Calcular( double numero1, double numero2, string operacao )
        {
            
            Calculo resposta = new Calculo();
            resposta.numero1 = numero1;
            resposta.numero2 = numero2;
            resposta.operacao = operacao;

            if(operacao == "Soma")
            {
                resposta.resultado = numero1 + numero2;
            }

            return View("Index", resposta );
        }

    }

}
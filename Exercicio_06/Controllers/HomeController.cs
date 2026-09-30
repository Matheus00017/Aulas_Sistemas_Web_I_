using Microsoft.AspNetCore.Mvc;
using Exercicio_06.Models;

namespace Exercicio_06.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Mensagem mensagem = new Mensagem();
            mensagem.texto = "Papa Bento XVII";
            return View(mensagem);
        }

        [HttpPost]


        public IActionResult Calculo( string operacao , double numero1 , double numero2, string erro )
        {

            Mensagem dcalculo = new Mensagem();
            dcalculo.operacao = operacao;
            dcalculo.numero1 = numero1;
            dcalculo.numero2 = numero2;
            

            if(operacao == "soma" || operacao == "+")
            {
                dcalculo.resultado = numero1 + numero2;
            }else if(operacao == "subtração" || operacao == "-")
            {
                dcalculo.resultado = numero1 - numero2;
            } else if(operacao == "divisao" || operacao == "/")
            {
                dcalculo.resultado = numero1 / numero2;
            }else if(operacao == "multiplicacao" || operacao == "*")
            {
                dcalculo.resultado = numero1 + numero2;
            }
            else
            {
                dcalculo.erro = "Não foi possivel realizar o calculo";
            }
            
            return View("Index", dcalculo);
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using Exercicio_01.Models;

namespace Exercicio_01.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Ana";
            return View(aluno);
        }
    }
}
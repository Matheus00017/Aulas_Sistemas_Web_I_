using Microsoft.AspNetCore.Mvc;
using Exercicio_02.Models;

namespace Exercicio_02.Controllers
{
    class HomeControlle : Controller
    {
        public IActionResult Index()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Matheus";
            aluno.Turma = "2° Infonet";
            return View (aluno);
        }
    }
}
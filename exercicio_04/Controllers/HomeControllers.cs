using Microsoft.AspNetCore.Mvc;
using Exercicio_04.Models;

namespace Exercicio_04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Mensagem mensagem = new Mensagem();
            mensagem.texto = "Salve o cortinas";
            mensagem.texto2 = "Cachorro cururu";
            // mensagem.imagemUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSIKKtGbW3SgFVjqOmL7psnWPjfJaLARf7tIg7UjgFzZlJ_6e6p-a4noF0&s=10";
            // mensagem.imagemUrl = "https://i.pinimg.com/236x/e7/5c/dc/e75cdc20868eeaa0f22c78c5cc1ff90d.jpg?nii=t";
            // mensagem.imagemUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQS7Lt4LKetlk_KDLh_19KpGc-okNuOOn6HW_110kX3kUsm47wgMMexI6E&s=10";
            mensagem.imagemUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMwIAq_fy9rM5F5wepPv5rrZjzTOk5xAh7XFYIvDibi6wT3gl-0YQ-sQg&s=10";
            return View(mensagem);
        }

        [HttpPost]

        public IActionResult botao()
        {
            Mensagem mensagem = new Mensagem();
            mensagem.texto3 = "Você acabou de clicar no botão do vitor hugo";
            return View( "Index", mensagem);
        }
    }
}
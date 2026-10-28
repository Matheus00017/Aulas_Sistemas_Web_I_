using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult crud()
        {
            return View();
        }

    }
}
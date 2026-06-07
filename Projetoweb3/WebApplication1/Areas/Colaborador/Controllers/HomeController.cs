using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Colaborador.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

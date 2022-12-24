using Microsoft.AspNetCore.Mvc;

namespace FProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

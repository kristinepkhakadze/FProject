using Microsoft.AspNetCore.Mvc;

namespace FProject.Controllers
{
    [ApiController]
    [Route("University")]
    public class UniversityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

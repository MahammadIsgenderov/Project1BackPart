using Microsoft.AspNetCore.Mvc;

namespace Proyekt1BackPart.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

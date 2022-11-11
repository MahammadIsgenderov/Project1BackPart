using Microsoft.AspNetCore.Mvc;

namespace Proyekt1BackPart.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

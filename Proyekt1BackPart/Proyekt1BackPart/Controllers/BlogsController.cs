using Microsoft.AspNetCore.Mvc;

namespace Proyekt1BackPart.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Proyekt1BackPart.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

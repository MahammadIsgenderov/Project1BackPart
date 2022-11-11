using Microsoft.AspNetCore.Mvc;

namespace Proyekt1BackPart.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

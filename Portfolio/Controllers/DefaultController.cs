using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

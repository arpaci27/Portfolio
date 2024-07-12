using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}

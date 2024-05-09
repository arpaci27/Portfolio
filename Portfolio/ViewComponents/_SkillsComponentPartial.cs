using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _SkillsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    }
}

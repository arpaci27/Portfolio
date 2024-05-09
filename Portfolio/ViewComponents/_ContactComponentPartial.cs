using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _ContactComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

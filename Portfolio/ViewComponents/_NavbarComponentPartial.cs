using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _NavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

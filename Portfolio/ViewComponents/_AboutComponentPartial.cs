using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _AboutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _HeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

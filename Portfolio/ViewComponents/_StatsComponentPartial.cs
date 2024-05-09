using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _StatsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

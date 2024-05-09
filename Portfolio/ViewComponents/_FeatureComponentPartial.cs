using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _FeatureComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

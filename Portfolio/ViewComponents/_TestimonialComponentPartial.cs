using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _TestimonialComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

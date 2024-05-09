using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _FooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

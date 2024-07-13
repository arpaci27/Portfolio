using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

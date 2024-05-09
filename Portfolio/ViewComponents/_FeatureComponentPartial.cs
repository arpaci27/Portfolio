using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _FeatureComponentPartial: ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext(); 
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}

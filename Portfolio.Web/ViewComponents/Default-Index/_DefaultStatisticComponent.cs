using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultStatisticComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.projectCount = context.Projects.Count();
            ViewBag.skillAverage = context.Skills.Any() ? context.Skills.Average(x => x.Percentage): 0.0;
            return View();
        }
    }
}

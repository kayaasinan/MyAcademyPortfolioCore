using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultResumeComponent(PortfolioContext context): ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = context.Abouts.FirstOrDefault();
            ViewBag.fullName = "Sinan Kaya";
            return View(values);
        }
    }
}

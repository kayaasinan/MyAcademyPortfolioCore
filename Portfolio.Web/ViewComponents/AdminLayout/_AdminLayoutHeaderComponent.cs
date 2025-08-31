using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeaderComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.username=HttpContext.Session.GetString("UserName");
            ViewBag.title = "Full Stack .Net Developer";
            ViewBag.unreadMessageCount = context.UserMessages.Where(x=>!x.IsRead).Count();
           var values = context.UserMessages .Where(x => !x.IsRead).OrderByDescending(x => x.UserMessageId).Take(3).ToList();
            return View(values);
        }
    }
}

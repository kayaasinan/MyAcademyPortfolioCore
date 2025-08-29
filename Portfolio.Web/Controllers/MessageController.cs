using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class MessageController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.UserMessages.ToList();
            return View(values);
        }
    }
}

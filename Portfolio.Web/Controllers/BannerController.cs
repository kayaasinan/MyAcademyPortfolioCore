using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class BannerController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values = context.Banners.ToList();
            return View(values);
        }

        public IActionResult CreateBanner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBanner(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }
            context.Banners.Add(banner);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBanner(int id)
        {
            var values = context.Banners.Find(id);
            context.Banners.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateBanner(int id)
        {
            var values = context.Banners.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateBanner(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }
            context.Banners.Update(banner);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class AboutController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            about.IsAvailable = true;
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateAbout(int id)
        {
            var values = context.Abouts.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
           
        }
        public IActionResult DeleteAbout(int id)
        {
            var values = context.Abouts.Find(id);
            if (values != null)
            {
                context.Abouts.Remove(values);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

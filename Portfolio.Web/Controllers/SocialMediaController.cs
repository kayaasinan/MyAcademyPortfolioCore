using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class SocialMediaController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.SocialMedias.ToList();
            return View(values);
        }
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            if (!ModelState.IsValid)
            {
                return View(socialMedia);
            }
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            if (!ModelState.IsValid)
            {
                return View(socialMedia);
            }
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

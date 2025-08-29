using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ExperienceController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Experiences.ToList();
            return View(values);
        }
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateExperience(int id)
        {
            var values = context.Experiences.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = context.Experiences.Find(id);
            context.Experiences.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

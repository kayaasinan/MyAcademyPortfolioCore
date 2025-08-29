using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class EducationController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Educations.ToList();
            return View(values);
        }
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateEducation(int id)
        {
            var values = context.Educations.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }
            context.Educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEducation(int id)
        {
            var values = context.Educations.Find(id);
            context.Educations.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

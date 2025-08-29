using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class SkillController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }
      
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateSkill(int id)
        {
            var values = context.Skills.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = context.Skills.Find(id);
            context.Skills.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

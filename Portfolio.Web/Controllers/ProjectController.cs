using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ProjectController(PortfolioContext context) : Controller
    {
        private void CategoryDropDown()
        {
            var categories = context.Categories.ToList();
            //Dropdown olarak kategori listeleme
            ViewBag.categories = (from x in categories
                                  select new SelectListItem
                                  {
                                      Text = x.CategoryName,
                                      Value = x.CategoryId.ToString()
                                  }).ToList();

        }
        public IActionResult Index()
        {
            //Eager Loading
            //Lazy Loading
            var projects = context.Projects.Include(x => x.Category).ToList();
            return View(projects);
        }
        public IActionResult CreateProject()
        {
            CategoryDropDown();
            return View();
        }
        [HttpPost]
        public IActionResult CreateProject(Project project)
        {
            CategoryDropDown();

            if (!ModelState.IsValid)
            {
                return View(project);
            }
            context.Projects.Add(project);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

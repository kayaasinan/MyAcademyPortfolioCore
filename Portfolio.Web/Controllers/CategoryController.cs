﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly PortfolioContext _context;

        public CategoryController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories= _context.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var values = _context.Categories.Find(id);
            _context.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values= _context.Categories.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

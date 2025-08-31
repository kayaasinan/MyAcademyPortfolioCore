using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ContactInfoController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.ContactInfos.ToList();
            return View(values);
        }
        public IActionResult CreateContactInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContactInfo(ContactInfo contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            context.ContactInfos.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteContactInfo(int id)
        {
            var values = context.ContactInfos.Find(id);
            context.ContactInfos.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateContactInfo(int id)
        {
            var values = context.ContactInfos.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContactInfo(ContactInfo contactInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(contactInfo);
            }
            context.ContactInfos.Update(contactInfo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

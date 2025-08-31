using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class AdminController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpdateAccountInfo()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult UpdateAccountInfo(string oldPassword,string newPassword)
        {
            var userName = HttpContext.Session.GetString("UserName");

            if (userName == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var user = context.Users.FirstOrDefault(x => x.UserName == userName);

            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı!");
                return View();
            }

            if (user.Password != oldPassword) 
            {
                ModelState.AddModelError("", "Lütfen eski şifrenizi doğru giriniz!");
                return View();
            }

            user.Password = newPassword;
            context.Update(user);
            context.SaveChanges();

            ViewBag.Success = "Şifreniz başarıyla değiştirildi.";
            return View();
        }
    }
}

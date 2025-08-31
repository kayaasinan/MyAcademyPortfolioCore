using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class MessageController(PortfolioContext context) : Controller
    {
        public IActionResult Index(int id = 0)
        {
            var values=context.UserMessages.ToList();
            ViewBag.messageCount = values.Count;
            ViewBag.readMessageCount = values.Count(X => X.IsRead);
            ViewBag.unreadMessageCount = values.Count(X => !X.IsRead);
            if (id==1)
            {
                values = values.Where(x => !x.IsRead).ToList();
            }
            else if (id == 2)
            {
                values=values.Where(x => x.IsRead).ToList();
            }
            ViewBag.MessageId = id;

                return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = context.UserMessages.Find(id);
            context.UserMessages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ContentMessage(int id)
        {
            // Mesajı getir
            var message = context.UserMessages.FirstOrDefault(x => x.UserMessageId == id);

            // Mesaj yoksa Index’e yönlendir
            if (message == null)
                return RedirectToAction("Index");

            // Mesajı okundu olarak işaretle
            if (!message.IsRead)
            {
                message.IsRead = true;
                context.SaveChanges();
            }

            // PartialView döndür
            return PartialView("ContentMessage", message);
        }
        public IActionResult Read(int id)
        {
            var values= context.UserMessages.Find(id);
            if (values != null)
            {
                values.IsRead = true;
                context.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }
        public IActionResult Unread(int id)
        {
            var values = context.UserMessages.Find(id);
            if (values != null)
            {
                values.IsRead = false;
                context.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}

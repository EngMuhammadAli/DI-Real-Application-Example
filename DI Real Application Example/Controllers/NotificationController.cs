using DI_Real_Application_Example.Service;
using Microsoft.AspNetCore.Mvc;

namespace DI_Real_Application_Example.Controllers
{
    public class NotificationController : Controller
    {
        private readonly IDIEmailService _emailService;

        public NotificationController(IDIEmailService emailService)
        {
            _emailService = emailService;
        }
        public IActionResult SendNotification()
        {
            var emailService = new EmailService();
            var result = emailService.SendEmail("user@example.com", "Hello", "This is a test email.");
            //Di
            var DIresult = _emailService.SendEmail("user@example.com", "Hello", "This is a test email.");

            ViewBag.Message = result;
            ViewBag.DIMessage = DIresult;
            return View();
        }
       
    }
}

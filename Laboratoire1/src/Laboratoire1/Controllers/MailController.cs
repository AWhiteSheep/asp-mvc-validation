using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoire1.Controllers
{
    public class MailController : Controller
    {
        public RedirectToActionResult Index()
        {
            return RedirectToAction(nameof(Send));
        }

        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToRouteResult Send(IFormCollection form)
        {
            MailAddress _from = new MailAddress(form["from"]);
            MailAddress _for = new MailAddress(form["for"]);

            // comme spécifié sur https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient.-ctor?view=netframework-4.8
            MailMessage message = new MailMessage(_from, _for);

            message.Subject = form["subject"];
            message.Body = form["contenu"];
            

            SmtpClient client = new SmtpClient();
            client.Send(message);

            return RedirectToRoute("Evaluation/Index");
        }

    }
}
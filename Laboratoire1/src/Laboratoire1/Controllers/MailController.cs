using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
/**
 * 
 * Yan Ha Routhier-Chevrier
 * 1473192 - laboratoire 1
 * 
 * référence pour le code d'envoie (port bloqué)
 * 
 * */
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
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(form["from"].ToString(), form["from"].ToString()));
            message.To.Add(new MailboxAddress(form["to"].ToString(), form["to"].ToString()));
            message.Subject = form["subject"].ToString();

            message.Body = new TextPart("plain")
            {
                Text = form["content"].ToString()
            };
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate(form["from"].ToString(), form["password"].ToString());
                client.Send(message);
                client.Disconnect(true);
            }

            return RedirectToRoute("Evaluation/Index");
        
        }





    }
}
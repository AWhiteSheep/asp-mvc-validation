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
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Exchange.WebServices.Autodiscover;
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
        public IActionResult Send(string from, string to, string subject, string content, string password)
        {            
            ExchangeService myservice = new ExchangeService(ExchangeVersion.Exchange2010_SP1);
            myservice.Credentials = new WebCredentials(from, password);

            try
            {
                string serviceUrl = "https://outlook.office365.com/ews/exchange.asmx";

                myservice.Url = new Uri(serviceUrl);
                EmailMessage emailMessage = new EmailMessage(myservice);
                emailMessage.Subject = subject;
                emailMessage.Body = new MessageBody(content);

                emailMessage.ToRecipients.Add(to);
                emailMessage.Send();
            }
            catch (SmtpException exception)
            {
                string msg = "Erreur:message n'a pas pu être envoyé";
                msg += exception.Message;
                throw new Exception(msg);
            }

            catch (AutodiscoverRemoteException exception)
            {
                string msg = "Erreur:message n'a pas pu être envoyé";
                msg += exception.Message;
                throw new Exception(msg);
            }

            RedirectToActionResult redirectToActionResult = new RedirectToActionResult("Accueil", "Evaluation", "");
            return redirectToActionResult;
        
        }





    }
}
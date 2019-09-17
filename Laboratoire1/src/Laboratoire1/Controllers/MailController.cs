using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoire1.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Send(FormCollection form)
        {
            return RedirectToRoute("Evaluation/Index");
        }

    }
}
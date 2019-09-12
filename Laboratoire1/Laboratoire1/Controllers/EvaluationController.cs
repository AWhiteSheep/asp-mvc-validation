using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoire1.Controllers
{
    public class EvaluationController : Controller
    {
        public RedirectToActionResult Index()
        {
            return RedirectToAction("Accueil");
        }

        public IActionResult Accueil()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
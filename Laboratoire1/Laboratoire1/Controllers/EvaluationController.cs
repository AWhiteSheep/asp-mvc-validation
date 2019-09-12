using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratoire1.Models;
using Microsoft.AspNetCore.Http;

namespace Laboratoire1.Controllers
{
    public class EvaluationController : Controller
    {
        public RedirectToActionResult Index()
        {
            return RedirectToAction(nameof(Accueil));
        }

        public IActionResult Accueil()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Evaluation evaluation)
        {
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult Update(int num_evaluation)
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Update(IFormCollection form)
        {
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult Delete(int num_evaluation)
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Delete(int num_evaluation, Evaluation evaluation)
        {
            return RedirectToAction(nameof(List));
        }
    }
}
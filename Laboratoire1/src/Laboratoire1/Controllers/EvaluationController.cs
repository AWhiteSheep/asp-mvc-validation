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

        [HttpGet]
        public IActionResult List()
        {
            return View(Evaluations.ListeEvaluations);
        }

        [HttpGet("/Evaluation/List/{type}/{m_message}")]
        public IActionResult List(string type, string m_message)
        {
            // will add modal message to the page
            ViewBag.m_message = m_message;
            ViewBag.type = type;
            return View(Evaluations.ListeEvaluations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet("/Evaluation/Create/{type}/{m_message}")]
        public IActionResult Create(string type, string m_message)
        {
            // will add modal message to the page
            ViewBag.m_message = m_message;
            ViewBag.type = type;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Create(Evaluation evaluation)
        {
            if (ModelState.IsValid) {
                Evaluations.Ajouter(evaluation);
                return RedirectToAction(nameof(List),
                    new UserMessage()
                    {
                        m_message = new string("Évaluation de " + evaluation.prenom_eleve + " ajouté avec succès!"),
                        type = UserMessage._type.SUCCESS
                    });                       
            }

            return RedirectToAction(nameof(Create),
                new UserMessage()
                {
                    m_message = new string("L'évaluation n'a pas pu être ajouté."),
                    type = UserMessage._type.ERROR
                });
        }

        [HttpGet]
        public IActionResult Update(int num_evaluation)
        {
            Evaluation  eval = Evaluations.ListeEvaluations.First(e => e.num_evaluation == num_evaluation);
            return View(eval);
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
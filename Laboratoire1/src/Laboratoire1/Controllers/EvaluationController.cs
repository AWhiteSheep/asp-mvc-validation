using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratoire1.Models;
using Microsoft.AspNetCore.Http;
/**
 * 
 * Yan Ha Routhier-Chevrier
 * 1473192 - laboratoire 1
 * 
 * */
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
        // emvoie à l'usagé la liste des évaluations.
        public IActionResult List()
        {
            return View(Evaluations.ListeEvaluations);
        }

        [HttpGet]
        [Route("/Evaluation/List/{type}/{m_message}")]
        // deux possibilités nous est offert pour créer la view, ici il y a un message.
        public IActionResult List(string type, string m_message)
        {
            ViewBag.m_message = m_message;
            ViewBag.type = type;
            return View(Evaluations.ListeEvaluations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        [Route("/Evaluation/Create/{type}/{m_message}")]
        // deux possibilités nous est offert pour créer la view, ici il y a un message.
        public IActionResult Create(string type, string m_message)
        {
            ViewBag.m_message = m_message;
            ViewBag.type = type;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // ajoute à la liste l'évaluation passé en paramètre, envoie un message de succès ou d'erreur en réponse.
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
        [ValidateAntiForgeryToken]
        // selon le formCollection une évaluation est créé pour supprimer et ajouter l'évaluation (agissant comme update)
        public RedirectToActionResult Update(IFormCollection form)
        {
            // soit un message de succès ou d'erreur est renvoyé à l'utilisateur
            if (ModelState.IsValid)
            {
                Evaluation evaluation = new Evaluation() {
                    num_evaluation = int.Parse(form["num_evaluation"]),
                    nom_eleve = form["nom_eleve"],
                    prenom_eleve = form["prenom_eleve"],
                    telephone_eleve = form["telephone_eleve"],
                    courriel_eleve = form["courriel_eleve"],
                    genre_eleve = char.Parse(form["genre_eleve"]),
                    note_evaluation = form["note_evaluation"],
                    date_evaluation = DateTime.Parse(form["date_evaluation"]),
                    commentaires_evaluation = form["commentaires_evaluation"]
                };
                Evaluations.Modifier(evaluation);
                return RedirectToAction(nameof(List),
                    new UserMessage()
                    {
                        m_message = new string("Évaluation de " + evaluation.prenom_eleve + " modifiée avec succès!"),
                        type = UserMessage._type.SUCCESS
                    });
            }

            return RedirectToAction(nameof(Create),
                new UserMessage()
                {
                    m_message = new string("L'évaluation n'a pas pu être modifiée."),
                    type = UserMessage._type.ERROR
                });
        }

        [HttpGet]
        // recherche et envoit la bonne évaluation à la view
        public IActionResult Delete(int num_evaluation)
        {
            Evaluation eval = Evaluations.ListeEvaluations.First(e => e.num_evaluation == num_evaluation);
            return View(eval);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // Supprime l'évaluation dans la liste, si échoue message envoyé à l'utilisateur
        public RedirectToActionResult Delete(int num_evaluation, Evaluation evaluation)
        {
            try
            {
                Evaluations.Supprimer(num_evaluation);
                return RedirectToAction(nameof(List),
                    new UserMessage()
                    {
                        m_message = new string("Évaluation de " + evaluation.prenom_eleve + " ajouté avec succès!"),
                        type = UserMessage._type.SUCCESS
                    });
            }
            catch {
                return RedirectToAction(nameof(Create),
                    new UserMessage()
                    {
                        m_message = new string("L'évaluation n'a pas pu être supprimé."),
                        type = UserMessage._type.ERROR
                    });
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/**
 * 
 * Yan Ha Routhier-Chevrier
 * 1473192 - laboratoire 1
 * 
 * */
namespace Laboratoire1.Models
{
    public static class Evaluations
    {
        public static List<Evaluation> ListeEvaluations = new List<Evaluation>() {
            new Evaluation() {
                num_evaluation = 548,
                nom_eleve = "Routhier-Chevrier",
                prenom_eleve = "Yan Ha",
                telephone_eleve = "819-265-5587",
                courriel_eleve = "yan@gmail.com",
                genre_eleve = 'M',
                note_evaluation = "100%",
                date_evaluation = new DateTime(2019,09,12),
                commentaires_evaluation = "Tès belle évaluation."
            }
        };

        public static void Ajouter(Evaluation e) {
            ListeEvaluations.Add(e);
        }

        public static void Supprimer(int num_evaluation) {
            ListeEvaluations.RemoveAll(e => e.num_evaluation == num_evaluation);
        }

        public static void Modifier(Evaluation e) {
            Supprimer(e.num_evaluation);
            Ajouter(e);
        }
    }
}

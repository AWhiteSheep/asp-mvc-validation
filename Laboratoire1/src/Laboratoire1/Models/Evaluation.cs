using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class Evaluation
    {
        [Required]
        [Display(Name = "#Évaluation")]
        [RegularExpression(@"^[0-9]+$")]
        public int num_evaluation { get; set; }
        [Required]
        [Display(Name = "Étudiant")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string nom_eleve { get; set; }
        [Required]
        [Display(Name = "Prénom")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string prenom_eleve { get; set; }
        [Required]
        [Display(Name = "Téléphone étudiant")]
        public string telephone_eleve { get; set; }
        [Required]
        [Display(Name = "Courriel étudiant")]
        public string courriel_eleve { get; set; }
        [Required]
        [Display(Name = "Sexe étudiant")]
        [RegularExpression("^H|h|f|F$")]
        public char genre_eleve { get; set; }
        [Required]
        [Display(Name = "Note évaluation")]
        [RegularExpression(@"^[0-9]+$")]
        [Range(0, 100)]
        public string note_evaluation { get; set; }
        [Required]
        [Display(Name = "Date évaluation")]
        [DataType(DataType.Date)]
        public DateTime date_evaluation { get; set; }
        [Required]
        [Display(Name = "Commentaire")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-\.,-_]*$")]
        public string commentaires_evaluation { get; set; }

    }
}

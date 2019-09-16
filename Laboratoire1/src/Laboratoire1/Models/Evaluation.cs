using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoire1.Models
{
    public class Evaluation
    {
        [Required]
        [Display(Name = "#Évaluation")]
        public int num_evaluation { get; set; }
        [Required]
        [Display(Name = "Étudiant")]
        public string nom_eleve { get; set; }
        [Required]
        [Display(Name = "Prénom")]
        public string prenom_eleve { get; set; }
        [Required]
        [Display(Name = "Téléphone é.")]
        public string telephone_eleve { get; set; }
        [Required]
        [Display(Name = "Courriel é.")]
        public string courriel_eleve { get; set; }
        [Required]
        [Display(Name = "Sexe é.")]
        public char genre_eleve { get; set; }
        [Required]
        [Display(Name = "Note évaluation")]
        public string note_evaluation { get; set; }
        [Required]
        [Display(Name = "Date évaluation")]
        public DateTime date_evaluation { get; set; }
        [Required]
        [Display(Name = "Commetaire")]
        public string commentaires_evaluation { get; set; }

    }
}

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
        [Display(Name = "Numéro de l'évaluation")]
        public int num_evaluation { get; set; }
        [Required]
        [Display(Name = "Nom de l'étudiant")]
        public string nom_eleve { get; set; }
        [Required]
        [Display(Name = "Prénom de l'étudiant")]
        public string prenom_eleve { get; set; }
        [Required]
        [Display(Name = "Téléphone de l'étudiant")]
        public string telephone_eleve { get; set; }
        [Required]
        [Display(Name = "Courriel de l'étudiant")]
        public string courriel_eleve { get; set; }
        [Required]
        [Display(Name = "Sexe de l'étudiant")]
        public char genre_eleve { get; set; }
        [Required]
        [Display(Name = "Note de l'évaluation")]
        public string note_evaluation { get; set; }
        [Required]
        [Display(Name = "Date de l'évaluation")]
        public DateTime date_evaluation { get; set; }
        [Required]
        [Display(Name = "Commetaire de l'évaluation")]
        public string commentaires_evaluation { get; set; }

    }
}

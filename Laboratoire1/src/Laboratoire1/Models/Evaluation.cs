using Laboratoire1.Attributs;
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
        [Complex(ErrorMessage = "Le champ {0} est invalide.")]
        public int num_evaluation { get; set; }
        [Required]
        [Display(Name = "Nom de l'étudiant")]
        [RegularExpression(@"^[A-Z][a-zA-Z \s-]+$", ErrorMessage = "Le prénom  doit commencer par une majuscule.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Le champ doit être au minimum {0} charactères.")]
        public string nom_eleve { get; set; }
        [Required]
        [Display(Name = "Prénom")]
        [RegularExpression(@"^[A-Z][a-zA-Z \s-]+$", ErrorMessage = "Le prénom  doit commencer par une majuscule.")]
        public string prenom_eleve { get; set; }
        [Required]
        [Display(Name = "Téléphone étudiant")]
        public string telephone_eleve { get; set; }
        [Required]
        [Display(Name = "Courriel étudiant")]
        [DataType(DataType.EmailAddress)]
        public string courriel_eleve { get; set; }
        [Required]
        [Display(Name = "Sexe étudiant")]
        [RegularExpression("^H|h|f|F$", ErrorMessage = "Le genre ne peut qu'être H, h, f ou F")]
        public char genre_eleve { get; set; }
        [Required]
        [Display(Name = "Note évaluation")]
        [Range(0, 100 , ErrorMessage = "La note doît être de 0 à 100")]
        public string note_evaluation { get; set; }
        [Required]
        [Display(Name = "Date évaluation")]
        [DataType(DataType.Date)]
        public DateTime date_evaluation { get; set; }
        [Required]
        [Display(Name = "Commentaire")]
        public string commentaires_evaluation { get; set; }

    }
}

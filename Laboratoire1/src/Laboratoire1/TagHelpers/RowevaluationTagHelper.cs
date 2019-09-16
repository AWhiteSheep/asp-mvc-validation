using Laboratoire1.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoire1.TagHelpers
{
    public class RowevaluationTagHelper : TagHelper
    {
        public Evaluation eval { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; // change the tag to a section
            output.Attributes.SetAttribute("class", "row");
            output.Attributes.SetAttribute("data-evaluation-numero", eval.num_evaluation);
            output.Attributes.SetAttribute("data-evaluation-nom", eval.nom_eleve);
            output.Attributes.SetAttribute("data-evaluation-prenom", eval.prenom_eleve);
            output.Attributes.SetAttribute("data-evaluation-telephone", eval.telephone_eleve);
            output.Attributes.SetAttribute("data-evaluation-courriel", eval.courriel_eleve);
            output.Attributes.SetAttribute("data-evaluation-genre", eval.genre_eleve);
            output.Attributes.SetAttribute("data-evaluation-note", eval.note_evaluation);
            output.Attributes.SetAttribute("data-evaluation-date", eval.date_evaluation);
            output.Attributes.SetAttribute("data-evaluation-commentaire", eval.commentaires_evaluation);
            output.Attributes.SetAttribute("onclick", "etudiantShow(this)");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoire1.TagHelpers
{
    public class RowcolminTagHelper : TagHelper
    {
        public string aspColLength { get; set; }
        /// <summary>
        /// Si aucun est spécifié il ne sera pas lié avec une colonne pour la valeur
        /// </summary>
        public string aspId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "row");
            // avant la conception de l'élément html il ajoute un div qui est la colonne
            var _colLength = aspColLength != null ? "col-" + aspColLength : "col";
            output.PreContent.AppendHtml($@"<div class='{_colLength}'>");
            // après la conception de l'élément html il ajoute un div qui lui agira comme cible pour le jquery
            // pour avoir un modal dynamique si le id est donné
            var _postHtml = aspId != null ? $"</div><div class='{_colLength}'><div id='{aspId}'></div></div>" : $"</div>";
            output.PostContent.AppendHtml(_postHtml);
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}

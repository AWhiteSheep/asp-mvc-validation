using Laboratoire1.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoire1.TagHelpers
{
    public class BiglinkTagHelper : TagHelper
    {
        public BiglinkContext info { get; set; }
        public string controller { get; set; }
        public string action { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var url = info.link ?? "/" + controller + "/" + action ?? "#";
            output.TagName = "section"; // change the tag to a section
            output.Content.SetHtmlContent(
                $@"
                <div class='me-card-shadow'>
                    <a href='{url}' class='me-card mdc-elevation--z1 mdc-ripple-surface'>
                        <table>
                            <tr>
                                <td width='40px'>
                                    <span class='material-icons md-24'>{info.icon}</span>
                                </td>
                                <td>
                                    <div style='text-align:left;'>{info.text}</div>
                                </td>
                            </tr>
                        </table>
                    </a>
                </div>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}

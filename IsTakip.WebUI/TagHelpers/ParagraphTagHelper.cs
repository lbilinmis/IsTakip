using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace IsTakip.WebUI.TagHelpers
{
    [HtmlTargetElement("isTakipParagrap")]
    public class ParagraphTagHelper : TagHelper
    {
        public string GelenData { get; set; } = "Gelecek Değer";
        public string Css { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            #region 1.Yontem
            //var tagBuilder = new TagBuilder("p");
            //tagBuilder.InnerHtml.AppendHtml("<b></b>");
            //output.Content.SetHtmlContent(tagBuilder);
            #endregion

            #region 2.Yontem
            //var stringBuilder = new StringBuilder();
            ////stringBuilder.Append("<p>");
            //stringBuilder.AppendFormat("<p><b> {0}</b></p>", "Gelecek Değer");
            //output.Content.SetHtmlContent(stringBuilder.ToString());
            #endregion

            #region 1.Yontem
            string data = string.Empty;
            string deger = "Gelecek Değer";
            //data = "<p><b>" + deger + " </b></p>";
            data = "<p style='" + Css + "'><b>" + GelenData + " </b></p>";
            output.Content.SetHtmlContent(data.ToString());
            #endregion


        }
    }
}

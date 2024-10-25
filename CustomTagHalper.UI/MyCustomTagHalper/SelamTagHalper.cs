using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHalper.UI.MyCustomTagHalper
{
    [HtmlTargetElement("selam")]
    public class SelamTagHalper:TagHelper
    {
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1"; //he etiketinin içinde yazacak
            output.Attributes.SetAttribute("style","color:green");
            output.Content.SetContent("Merhaba hoşgeldiniz");
        }
    }
}

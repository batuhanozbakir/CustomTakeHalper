using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHalper.UI.MyCustomTagHalper
{
    [HtmlTargetElement("efnan")]
    public class EfnanTagHalper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1"; //he etiketinin içinde yazacak
            output.Attributes.SetAttribute("style", "color:red");
            output.Content.SetContent("Efnan bize brownie yap");
        }
    }
}

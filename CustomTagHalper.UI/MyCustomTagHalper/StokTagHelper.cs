using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHalper.UI.MyCustomTagHalper
{
    [HtmlTargetElement("stok-durum")]
    public class StokTagHelper:TagHelper
    {
        public int Stok { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";

            string renk;
            string mesaj;

            if (Stok > 20)
            {
                renk = "green";
                mesaj = $"Stok durumu {Stok} adet - yeterli adet var";
            }
            else if (Stok > 10)
            {
                renk = "orange";
                mesaj = $"Stok durumu {Stok} adet - kritik adet var";
            }
            else
            {
                renk = "red";
                mesaj = $"Stok durumu {Stok} adet - bitti bitecek";
            }

            output.Attributes.SetAttribute("style", $"color:{renk}");
            output.Content.SetContent(mesaj);

                
                
        }
    }
}

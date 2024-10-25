using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHalper.UI.MyCustomTagHalper
{
    [HtmlTargetElement("login-form")]
    public class LoginTagHelper:TagHelper
    {
        public string KullaniciAdi { get; set; } = "admin";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "form";
            output.Attributes.SetAttribute("method", "post");
            output.Attributes.SetAttribute("action", "/MyCustomTagHelper/Giris");

            output.Content.SetHtmlContent($@"
            
             <label for='kullanici'> Kullanıcı Adı </label>
             <input type = 'text' id='kullanici' name='kullaniciAdi'/>
             <button type='submit'>Giriş Yap</button>

            ");
        }
    }
}

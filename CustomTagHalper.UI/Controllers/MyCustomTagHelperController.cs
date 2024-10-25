using Microsoft.AspNetCore.Mvc;

namespace CustomTagHalper.UI.Controllers
{
    public class MyCustomTagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Giris(string kullaniciAdi)
        {
            if(kullaniciAdi == "admin")
            {
                ViewBag.Message = "Hoş Geldiniz";
                return View("Giris");
            }
            ViewBag.Message = "Kullanici Adi Hatali";
            return View("GirisYap");
            
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCQueryString.UI.Models;

namespace MVCQueryString.UI.Controllers
{

    public class OgrenciController : Controller
    {
        private static List<Ogrenci> ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci {Id =1, Ad = "Ahmet"},
            new Ogrenci {Id =2, Ad = "Mehmet"},

        };

        public IActionResult Yeni()
        {
            return View();
        }
        public IActionResult Ekle(string ad)
        {
            if (!string.IsNullOrWhiteSpace(ad))
            {
                var yeniOgrenci = new Ogrenci
                {
                    Id = ogrenciler.Count + 1,
                    Ad = ad
                };
                ogrenciler.Add(yeniOgrenci);
            }
            return RedirectToAction("Liste");
        }
        public IActionResult Liste()
        {
            ViewData["Ogrenciler"] = ogrenciler;
            return View();
        }
    }
}
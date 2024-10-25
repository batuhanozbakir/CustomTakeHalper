using Microsoft.AspNetCore.Mvc;
using MVCAttributeRoute.UI.Models;

namespace MVCAttributeRoute.UI.Controllers
{
    [Route("kullanici")]
    public class UserController : Controller
    {
        private static List<User> users = new List<User>()
        {
            new User {Id =1, Name ="Efnan",Email = "efnan@mail.com"},
            new User {Id =2, Name ="Meltem",Email = "meltem@mail.com"}
        };

        [HttpGet("listele")]
        public IActionResult Liste()
        {
            ViewData["Users"] = users;
            return View();
        }

        [HttpPost("Ekle")]
        public IActionResult Ekle(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return RedirectToAction("Liste");
        }

        [HttpGet("Ekle")]
        public IActionResult Ekle()
        {    
            return View();
        }
    }
}

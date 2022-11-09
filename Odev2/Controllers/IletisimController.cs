using Microsoft.AspNetCore.Mvc;

namespace Odev2.Controllers
{
    public class IletisimController : Controller
    {
        [HttpPost]
        public IActionResult Index(IFormCollection collections)
        {
            ViewBag.Name = collections["_name"];
            ViewBag.Email = collections["email"];
            ViewBag.Mesaj = collections["mesaj"];
            ViewBag.Check = collections["kontrol"][0];


            return View();
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}

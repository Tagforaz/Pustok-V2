using Microsoft.AspNetCore.Mvc;

namespace PustokPB306.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}

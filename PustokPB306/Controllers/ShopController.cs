using Microsoft.AspNetCore.Mvc;

namespace PustokPB306.Controllers
{
    public class ShopController : Controller
    {
        [Route ("shop")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

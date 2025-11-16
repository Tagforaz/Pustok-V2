using Microsoft.AspNetCore.Mvc;

namespace PustokPB306.Controllers
{
    public class AuthController : Controller
    {
        [Route ("auth")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

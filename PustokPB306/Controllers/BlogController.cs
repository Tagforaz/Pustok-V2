using Microsoft.AspNetCore.Mvc;

namespace PustokPB306.Controllers
{
    public class BlogController : Controller
    {
        [Route ("blog")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}

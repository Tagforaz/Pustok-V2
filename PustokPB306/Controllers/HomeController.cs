using Microsoft.AspNetCore.Mvc;
using PustokPB306.DAL;
using PustokPB306.Models;
using PustokPB306.ViewModels;

namespace PustokPB306.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slide> slides = _context.Slides.Take(2).ToList();
            HomeVM homeVM = new HomeVM
            {
                Slides = slides
            };
            return View(homeVM);
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

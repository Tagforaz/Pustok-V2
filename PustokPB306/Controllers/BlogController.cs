using Microsoft.AspNetCore.Mvc;
using PustokPB306.DAL;
using PustokPB306.Models;
using PustokPB306.ViewModels;

namespace PustokPB306.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        [Route ("blog")]
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.OrderBy(b=>b.CreatedAt).ToList();
            BlogVM blogVM = new BlogVM
            {
                Blogs = blogs
            };
            return View(blogVM);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PustokPB306.Models;

namespace PustokPB306.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        { }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}

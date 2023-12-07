using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
using DemoMVC.Models;
using DemoMVC.Model;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;} 
        public DbSet<Author> Author { get; set; } = default!;
        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<DemoMVC.Model.Student> Student { get; set; } = default!;
              

    }
    
}
//Le Quynh Anh_2021050074
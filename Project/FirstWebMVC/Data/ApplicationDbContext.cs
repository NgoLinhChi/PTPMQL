using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee { get; set;}
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<DaiLy> DaiLy { get; set; } = default!;

    }
}
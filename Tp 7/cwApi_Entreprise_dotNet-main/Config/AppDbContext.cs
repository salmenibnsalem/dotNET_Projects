using cwAPIdotNET.Models;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Magasin.Config
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public static object Employee { get; internal set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
    
}

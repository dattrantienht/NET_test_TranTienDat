using Microsoft.EntityFrameworkCore;
using NET_test_TranTienDat.Models;

namespace NET_test_TranTienDat.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

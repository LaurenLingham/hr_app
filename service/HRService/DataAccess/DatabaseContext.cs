using HRService.Models;
using Microsoft.EntityFrameworkCore;

namespace HRService.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DatabaseContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }
    }
}

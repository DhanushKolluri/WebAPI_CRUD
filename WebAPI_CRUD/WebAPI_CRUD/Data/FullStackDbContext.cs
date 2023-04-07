using Microsoft.EntityFrameworkCore;
using WebAPI_CRUD.Models;

namespace WebAPI_CRUD.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskContext : DbContext
    {
        public DatabaseTaskContext(DbContextOptions<DatabaseTaskContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

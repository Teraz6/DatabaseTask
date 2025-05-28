using DatabaseTask.Core.Models;
using Microsoft.EntityFrameworkCore;

public partial class DatabaseTaskContext : DbContext
{
    public DatabaseTaskContext(DbContextOptions<DatabaseTaskContext> options)
        : base(options)
    {
    }

    // DbSets for each entity in DatabaseTask.Core.Models
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<JobHistory> JobHistories { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Access> Accesses { get; set; }
    public DbSet<Child> Children { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<Devices> Devices { get; set; }
    public DbSet<WorkTopic> WorkTopics { get; set; }
    public DbSet<Hint> Hints { get; set; }
    public DbSet<Request> Requests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Place for custom configuration if needed

        base.OnModelCreating(modelBuilder);
    }
}
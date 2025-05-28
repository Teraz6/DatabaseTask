using DatabaseTask.Core.Models;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.EntityFrameworkCore;
using System.Net;

public class DatabaseTaskContext : DbContext
{
    // DbSets for each table
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<JobHistory> JobHistories { get; set; }
    public DbSet<Position> Positions { get; set; }

    // Constructor to configure the context
    public DatabaseTaskContext(DbContextOptions<DatabaseTaskContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure relationships and constraints if needed

        base.OnModelCreating(modelBuilder);
    }
}
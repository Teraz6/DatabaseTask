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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration- see https://go.microsoft.com/fwlink/?linkid=2131148.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DatabaseTask;Trusted_Connection=true;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Employee
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Phone).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.PersonalCode);
            entity.Property(e => e.AddressId).IsRequired();

            entity.HasOne(e => e.Address)
                .WithMany(a => a.Employees)
                .HasForeignKey(e => e.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(e => e.JobHistories)
                .WithOne(jh => jh.Employee)
                .HasForeignKey(jh => jh.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Address
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.PostalCode).IsRequired();
            entity.Property(a => a.AppartmentNr).IsRequired();
            entity.Property(a => a.BuildingNr).IsRequired();
            entity.Property(a => a.Street).IsRequired();
            entity.Property(a => a.District).IsRequired();
            entity.Property(a => a.City).IsRequired();
            entity.Property(a => a.County).IsRequired();
            entity.Property(a => a.Country).IsRequired();

            entity.HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // JobHistory
        modelBuilder.Entity<JobHistory>(entity =>
        {
            entity.HasKey(jh => jh.Id);
            entity.Property(jh => jh.StartDate).IsRequired();

            entity.HasOne(jh => jh.Position)
                .WithMany(p => p.JobHistory)
                .HasForeignKey(jh => jh.PositionId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(jh => jh.Employee)
                .WithMany(e => e.JobHistories)
                .HasForeignKey(jh => jh.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Position
        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.PositionCreatedDate).IsRequired();

            entity.HasOne(p => p.Access)
                .WithMany(a => a.Positions)
                .HasForeignKey(p => p.AccessId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Access
        modelBuilder.Entity<Access>(entity =>
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Description).IsRequired();
        });

        // Salary
        modelBuilder.Entity<Salary>(entity =>
        {
            entity.HasKey(s => s.Id);
            entity.Property(s => s.Wage).IsRequired();
            entity.Property(s => s.StartDate).IsRequired();

            entity.HasOne(s => s.Employee)
                .WithMany()
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Devices
        modelBuilder.Entity<Devices>(entity =>
        {
            entity.HasKey(d => d.Id);
            entity.Property(d => d.Name).IsRequired();
        });

        // WorkTopic
        modelBuilder.Entity<WorkTopic>(entity =>
        {
            entity.HasKey(wt => wt.Id);
            entity.Property(wt => wt.Description).IsRequired();
        });

        // Hint
        modelBuilder.Entity<Hint>(entity =>
        {
            entity.HasKey(h => h.Id);

            entity.HasOne(h => h.WorkTopic)
                .WithMany(wt => wt.Hint) // renamed from Hint to Hints
                .HasForeignKey(h => h.WorkTopicId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(h => h.Employee)
                .WithMany()
                .HasForeignKey(h => h.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Child
        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.BirthDate).IsRequired();
            entity.Property(c => c.FirstName).IsRequired();
            entity.Property(c => c.LastName).IsRequired();

            entity.HasOne(c => c.Parent)
                .WithMany()
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Request
        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(r => r.Id);
            entity.Property(r => r.Description).IsRequired();
            entity.Property(r => r.CreatedDate).IsRequired();

            entity.HasOne(r => r.WorkTopic)
                .WithMany(wt => wt.Requests)
                .HasForeignKey(r => r.WorkTopicId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(r => r.Employee)
                .WithMany()
                .HasForeignKey(r => r.CreatorEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        base.OnModelCreating(modelBuilder);
    }
}

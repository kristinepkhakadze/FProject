using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using FinalProject.Configuration;
using System.Security.Principal;

namespace FinalProject;
public class UniversityDbContext : DbContext
{
    public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
    {
    }
    public DbSet<Address> Address { get; set; }
    public DbSet<Balance> Balance { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<Room> Room { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
    public DbSet<Semester> Semester { get; set; }
    public DbSet<Student> Student { get; set; }
    public DbSet<StudentSubject> StudentSubject { get; set; }
    public DbSet<Subject> Subject { get; set; }
    public DbSet<Teacher> Teacher { get; set; }
    
   // protected override void OnModelCreating(ModelBuilder modelBuilder)
   // {
   //     modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
   // }
}

  
   

using io.Models;
using Microsoft.EntityFrameworkCore;

namespace io;

public class ApplicationContext:DbContext
{
    // public ApplicationContext()
    // {
    //     //Database.EnsureCreated();
    // }
    public DbSet<Employee> Employees { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql( "Host=localhost;Port=5432;Database=CrudMigration_db;Username=postgres;Password=12345;");
    }
}
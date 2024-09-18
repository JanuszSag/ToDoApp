using Microsoft.EntityFrameworkCore;
using ToDoApp.Configurations;

namespace ToDoApp.Models;

public class ToDoContext : DbContext
{
    public ToDoContext()
    {
        
    }

    public ToDoContext(DbContextOptions<DbContext> options) : base(options)
    {
        
    }
    
    public virtual DbSet<ToDoTask> ToDoTask { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ToDoConfig());

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=(localDb)\\MSSQLLocalDb;Initial Catalog=ToDo;Integrated Security=True");
        base.OnConfiguring(optionsBuilder);
    }
}
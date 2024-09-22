using Microsoft.EntityFrameworkCore;
using ToDoApp.Configurations;

namespace ToDoApp.Models;

public class ToDoContext(DbContextOptions<ToDoContext> options) : DbContext(options)
{
    public DbSet<ToDoTask> ToDoTask { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ToDoConfig());

    }
}
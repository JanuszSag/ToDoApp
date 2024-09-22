using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Models;

namespace ToDoApp.Configurations;

public class ToDoConfig : IEntityTypeConfiguration<ToDoTask>
{
    public void Configure(EntityTypeBuilder<ToDoTask> builder)
    {
        builder.HasKey(x => x.Id).HasName("Id");
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        builder.Property(x => x.IsCompleted).HasDefaultValue(false).IsRequired();

        var toDoItems = new List<ToDoTask>();
        
        toDoItems.Add(new ToDoTask
        {
            Id = -1,
            Name = "Task 1",
            IsCompleted = false
        });
        toDoItems.Add(new ToDoTask
        {
            Id = -2,
            Name = "Task 1",
            IsCompleted = false
        });
        toDoItems.Add(new ToDoTask
        {
            Id = -3,
            Name = "Task 3",
            IsCompleted = true
        });

        builder.HasData(toDoItems);
    }
}
using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Services;

public class ToDoService(ToDoContext _context)
{
    public async Task AddToDoItemAsync(ToDoTask item)
    {
        _context.ToDoTask.Add(new ToDoTask
        {
            Id = 0,
            Name = item.Name,
            IsCompleted = item.IsCompleted,
            
        });
        Console.WriteLine(_context.ToDoTask.ToList().Count);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveToDoItemAsync(int id)
    {
        var itemToRemove = await _context.ToDoTask.FindAsync(id);
        if (itemToRemove == null)
            return;
        
        _context.ToDoTask.Remove(itemToRemove);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ToDoTask>> getAllToDoItemsListAsync()
    {
        var toDoItems = await _context.ToDoTask.ToListAsync();
        return toDoItems;
    }

    public async Task HandleCheckbox(bool value, int id)
    {
        var itemToChange = await _context.ToDoTask.FindAsync(id);
        itemToChange.IsCompleted = value;
        await _context.SaveChangesAsync();
        
    }

}
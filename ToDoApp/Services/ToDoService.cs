using Microsoft.EntityFrameworkCore;
using ToDoApp.Components.Services;
using ToDoApp.DTO;
using ToDoApp.Models;

namespace ToDoApp.Services;

public class ToDoService : IToDoService
{
    private readonly ToDoContext _context;

    public ToDoService(ToDoContext context)
    {
        _context = context;
    }
    public async Task AddToDoItemAsync(ToDoTaskDTO item)
    {
        _context.ToDoTask.Add(new ToDoTask
        {
            Id = item.Id,
            Name = item.Name,
            IsCompleted = item.IsCompleted,
            
        });
        Console.WriteLine(_context.ToDoTask.ToList().Count);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveToDoItemAsync(int id)
    {
        var itemToRemove = _context.ToDoTask.ToList().Find(o => o.Id == id);
        _context.ToDoTask.Remove(itemToRemove);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ToDoTaskDTO>> getAllToDoItemsListAsync()
    {
        var toDoItems = await _context.ToDoTask.Include(t=>t.Id)
                                               .Include(t=>t.Name)
                                               .Include(t=>t.IsCompleted)
                                               .Select(t=>new ToDoTaskDTO(t.Id,t.Name,t.IsCompleted))
                                               .ToListAsync();
        return toDoItems;
        
    }

}
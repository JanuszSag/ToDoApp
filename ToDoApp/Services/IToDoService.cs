using ToDoApp.DTO;
using ToDoApp.Models;

namespace ToDoApp.Components.Services;

public interface IToDoService
{
    public Task AddToDoItemAsync(ToDoTaskDTO item);
    public Task<List<ToDoTaskDTO>> getAllToDoItemsListAsync();
}
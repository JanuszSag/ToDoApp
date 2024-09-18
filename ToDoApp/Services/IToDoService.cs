using ToDoApp.Models;

namespace ToDoApp.Components.Services;

public interface IToDoService
{
    public Task AddToDoItemAsync(ToDoTask item);
}
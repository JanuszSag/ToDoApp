namespace ToDoApp.DTO;

public class ToDoTaskDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool isCompleted { get; set; }

    public ToDoTaskDTO(int id, string? title, bool isCompleted)
    {
        Id = id;
        Title = title;
        this.isCompleted = isCompleted;
    }
}
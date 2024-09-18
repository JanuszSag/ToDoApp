namespace ToDoApp.DTO;

public class ToDoTaskDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsCompleted { get; set; }

    public ToDoTaskDTO(int Id, string? Name, bool IsCompleted)
    {
        this.Id = Id;
        this.Name = Name;
        this.IsCompleted = IsCompleted;
    }
}
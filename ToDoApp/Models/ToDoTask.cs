using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models;

public class ToDoTask(string name, bool isCompleted)
{
     
        [Key] public int Id { get; set; }
        [Required] [MaxLength(100)] public string Name { get; set; } = name; 
        [Required] [DefaultValue(false)] public bool IsCompleted { get; set; } = isCompleted;

        public ToDoTask() : this(string.Empty, false)
        {
        }
}

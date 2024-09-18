using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models;

public class ToDoTask
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [Required]
    [DefaultValue(false)]
    public bool IsCompleted { get; set; }
    
}
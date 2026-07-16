using System.ComponentModel.DataAnnotations;



public class CreateTodoTaskRequest
{
    [Required]
    public string Title { get; set; } = string.Empty;

    public bool Done { get; set; }
}
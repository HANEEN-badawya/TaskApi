
using Microsoft.AspNetCore.Mvc;

[ApiController]

[Route("tasks")]
public class TasksController : ControllerBase
{
   private static List<TodoTask> tasks = new List<TodoTask>
   {
        new TodoTask
    {
         Id = 1,
        Title= "study api",
        Done = true
    },

    new TodoTask
    {
        Id = 2, 
        Title = "Finish Assignment",
        Done = false
    },

    new TodoTask
    {
        Id = 3,
        Title = "Read Documentation",
        Done = false
    }
   };
   [HttpGet("{id}")]

    public ActionResult <List<TodoTask>> GetTask(int id )
    {
        
         var task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            return NotFound(new
{
    error = "Task not found."
});
        }

        return Ok(task);
    }

 [HttpPost]
public ActionResult<TodoTask> CreateTask(CreateTodoTaskRequest request)
{
    if (string.IsNullOrWhiteSpace(request.Title))
     {
    return BadRequest(new
     {
    error = "Title is required."
});
}
    var task = new TodoTask
    {
        Id = tasks.Max(t => t.Id) + 1,
        Title = request.Title,
        Done = request.Done
    };
    tasks.Add(task);
    return CreatedAtAction(
    "GetTask",
    new { id = task.Id },
    task
);
}

[HttpPut("{id}")]

    public ActionResult <TodoTask> UpdateTask(int id , CreateTodoTaskRequest request)
    {
          if (string.IsNullOrWhiteSpace(request.Title))
     {
    return BadRequest(new
     {
    error = "Title is required."
});
}
         var task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            return NotFound(new
{
    error = "Task not found."
});
        }
        
            task.Title = request.Title;
            task.Done = request.Done;
        

        return Ok(task);
    }

[HttpDelete("{id}")]

    public ActionResult DeleteTask(int id)
    {
        
         var task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            return NotFound(new
{
    error = "Task not found."
});
        }
        
         tasks.Remove(task);
         return NoContent();

    }

        
    

    
};

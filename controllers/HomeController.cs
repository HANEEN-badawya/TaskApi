using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route( "" )] 
public class HomeController : ControllerBase
{
[HttpGet]
  public object Getinfo()
{
  return new
{
   name="Task API",
  version= "1.0",
  endpoints=new[]{ 
    "/tasks",
  }
};
}
[HttpGet("health")]
public object Health()
    {
        return new{
        status  = "ok",
    };
    
    }
}   
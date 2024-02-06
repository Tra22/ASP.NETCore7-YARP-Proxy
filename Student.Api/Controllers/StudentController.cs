using Microsoft.AspNetCore.Mvc;

namespace Student.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{

    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<object> Get()
    {
        return Enumerable.Range(1, 10).Select(index => new 
        {
            Id = index,
            Name = "Test "+ index,
        })
        .ToArray();
    }
}

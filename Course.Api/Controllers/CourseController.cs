using Microsoft.AspNetCore.Mvc;

namespace Course.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{

    private readonly ILogger<CourseController> _logger;

    public CourseController(ILogger<CourseController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<object> Get()
    {
        return Enumerable.Range(1, 10).Select(index => new 
        {
            Id = index,
            Name = "Course "+ index,
        })
        .ToArray();
    }
}

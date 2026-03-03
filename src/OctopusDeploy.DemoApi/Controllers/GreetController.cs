using Microsoft.AspNetCore.Mvc;
using OctopusDeploy.DemoApi.Services;

namespace OctopusDeploy.DemoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class GreetController : ControllerBase
{
    private readonly GreetingService _greeting;

    public GreetController(GreetingService greeting) => _greeting = greeting;

    [HttpGet]
    public ActionResult<string> Get([FromQuery] string? name)
        => Ok(_greeting.GetGreeting(name));
}
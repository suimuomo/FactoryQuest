using Microsoft.AspNetCore.Mvc;

namespace FactoryQuest.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPlayer()
    {
        var player = new
        {
            Id = 1,
            Name = "新人探索者",
            Level = 1,
            Experience = 0,
            Gold = 100
        };

        return Ok(player);
    }
}
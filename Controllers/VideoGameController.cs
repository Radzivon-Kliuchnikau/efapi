using efapi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace efapi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VideoGameController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<VideoGame>>> GetAllGames()
    {
        return Ok();
    }
}

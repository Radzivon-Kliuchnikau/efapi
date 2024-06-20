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
        var videoGames = new List<VideoGame>
        {
            new VideoGame
            {
                Name = "Red Dead Redemption",
                Description = "Cool Game",
                Platforms = new List<Platform>
                {
                    new Platform
                    {
                        Name = "PS4"
                    },
                    new Platform
                    {
                        Name = "PC"
                    }
                },
                Genre = "RPG"

            }
        };

        return Ok(videoGames);
    }
}

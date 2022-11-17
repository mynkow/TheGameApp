using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamePlatform.Api.Controllers
{
    [Route("Game")]
    [ApiController]
    public class GamePlatformController : ControllerBase
    {
        [Route("CreateGame")]
        public async Task<IActionResult> CreateGameAsync()
        {
            return Ok();
        }
    }
}

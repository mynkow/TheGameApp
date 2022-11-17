using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GamePlatform.Api.Controllers
{
    [Route("Game")]
    public class GamePlatformController : ApiControllerBase
    {
        private readonly GameAppService gameService;

        public GamePlatformController(GameAppService gameService)
        {
            this.gameService = gameService;
        }

        [HttpPost, Route("CreateGame")]
        public async Task<IActionResult> CreateGameAsync([FromBody] CreateGameRequest request)
        {
            return Ok();
        }
    }

    public class CreateGameRequest
    {
        [Required]
        public string Name { get; set; }
    }
}

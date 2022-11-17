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
            Guid gameId = gameService.CreateGame(request.Name);

            return new OkObjectResult(new { GameId = gameId });
        }

        [HttpPost, Route("SetPrice")]
        public async Task<IActionResult> SetPriceAsync([FromBody] SetGamePriceRequest request)
        {
            Guid gameId = request.Id;
            if (CurrenCode.IsValidCode(request.CurrencyCode) == false)
                return BadRequest("Currencyto ti ne e OK");

            var gamePrice = new Money(request.Amount, request.CurrencyCode);

            gameService.SetPrice(gameId, gamePrice);

            return Ok();
        }
    }

    public class CreateGameRequest
    {
        [Required]
        public string Name { get; set; }
    }

    public class SetGamePriceRequest
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Range(0.000000001, 10000)]
        public decimal Amount { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "ISO standard Brad mi"), MaxLength(3, ErrorMessage = "ISO standard Brad mi")]
        public string CurrencyCode { get; set; }
    }

}

using FootballersAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace FootballersAPI.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayersService _playerService;

        public PlayerController(IPlayersService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _playerService.GetPlayers();

            return Ok(players);
        }
    }
}
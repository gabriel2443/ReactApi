using FootballersAPI.Service;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors("Policy1")]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _playerService.GetPlayers();

            return Ok(players);
        }

        [HttpGet("{id}")]
        [EnableCors("Policy1")]
        public async Task<IActionResult> GetPlayer(int id)
        {
            var player = await _playerService.GetPlayerById(id);
            if (player is null)
            {
                return NotFound();
            }
            return Ok(player);
        }
    }
}
using FootballersAPI.Models;

namespace FootballersAPI.Service
{
    public interface IPlayersService
    {
        Task<List<Player>> GetPlayers();

        Task<Player?> GetPlayerById(int id);
    }
}
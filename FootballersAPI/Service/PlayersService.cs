using FootballersAPI.Data;
using FootballersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballersAPI.Service
{
    public class PlayersService : IPlayersService
    {
        private readonly DataContext _context;

        public PlayersService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Player>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task<Player?> GetPlayerById(int id)
        {
            return await _context.Players.FindAsync(id);
        }
    }
}